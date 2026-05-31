using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject_RailwayReservation.DB;

namespace MiniProject_RailwayReservation.Services
{
    internal class BookingService
    {
        DbConnection db = new DbConnection();

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dataReader = null;
        public void BookTicket(int userId)
        {
            try
            {
                Console.Write("Enter Class Id : ");
                int classId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Travel Date (YYYY-MM-DD HH:MM) : ");
                DateTime travelDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter Number of Seats : ");
                int noOfSeats = Convert.ToInt32(Console.ReadLine());

                if (noOfSeats > 3)
                {
                    Console.WriteLine("Maximum 3 seats can be booked.");
                    conn.Close();
                    return;
                }

                conn = db.GetConnection();

                string query = @"select TrainId, ClassName, AvailableSeats, Fare from TrainClass where ClassId = @ClassId";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClassId", classId);

                conn.Open();

                dataReader = cmd.ExecuteReader();

                int trainId = 0;
                int availableSeats = 0;
                decimal fare = 0;

                if (dataReader.Read())
                {
                    trainId = Convert.ToInt32(dataReader["TrainId"]);
                    availableSeats = Convert.ToInt32(dataReader["AvailableSeats"]);
                    fare = Convert.ToDecimal(dataReader["Fare"]);
                }

                else
                {
                    Console.WriteLine("Invalid Class Id");
                    dataReader.Close();
                    conn.Close();
                    return;
                }
                dataReader.Close();


                if (noOfSeats > availableSeats)
                {
                    Console.WriteLine("Not enough seats available");
                    conn.Close();
                    return;
                }

                decimal totalAmount = fare * noOfSeats;

                string bookingQuery = @"INSERT INTO Booking
                                    (UserId, TrainId, ClassId, TravelDate, NoOfSeats, TotalAmount)
                                    VALUES
                                    (@UserId, @TrainId, @ClassId, @TravelDate, @NoOfSeats, @TotalAmount)";

                SqlCommand bookingCmd = new SqlCommand(bookingQuery, conn);

                bookingCmd.Parameters.AddWithValue("@UserId", userId);
                bookingCmd.Parameters.AddWithValue("@TrainId", trainId);
                bookingCmd.Parameters.AddWithValue("@ClassId", classId);
                bookingCmd.Parameters.AddWithValue("@TravelDate", travelDate);
                bookingCmd.Parameters.AddWithValue("@NoOfSeats", noOfSeats);
                bookingCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                bookingCmd.ExecuteNonQuery();

                // Update Available Seats
                string updateQuery = @"
                                    UPDATE TrainClass
                                    SET AvailableSeats = AvailableSeats - @Seats
                                    WHERE ClassId = @ClassId";

                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);

                updateCmd.Parameters.AddWithValue("@Seats", noOfSeats);
                updateCmd.Parameters.AddWithValue("@ClassId", classId);

                updateCmd.ExecuteNonQuery();

                Console.WriteLine("\nTicket Booked Successfully");
                Console.WriteLine($"Total Amount : {totalAmount}");

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ViewTicket(int userId)
        {
            conn = db.GetConnection();

            string query = @"SELECT b.BookingId,
                            td.TrainName,
                            tc.ClassName,
                            b.TravelDate,
                            b.NoOfSeats,
                            b.TotalAmount,
                            b.BookingStatus
                     FROM Booking b
                     INNER JOIN TrainDetails td
                     ON b.TrainId = td.TrainId
                     INNER JOIN TrainClass tc
                     ON b.ClassId = tc.ClassId
                     WHERE b.UserId = @UserId and b.BookingStatus = 'Booked'";

            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserId", userId);

            conn.Open();

            dataReader = cmd.ExecuteReader();

            Console.WriteLine("\n===========  MY BOOKINGS  ===========");
            bool found  = false;

            while (dataReader.Read())
            {
                found = true;

                Console.WriteLine($"Booking ID    : {dataReader["BookingId"]}");
                Console.WriteLine($"Train Name    : {dataReader["TrainName"]}");
                Console.WriteLine($"Class         : {dataReader["ClassName"]}");
                Console.WriteLine($"Travel Date   : {Convert.ToDateTime(dataReader["TravelDate"]).ToShortDateString()}");
                Console.WriteLine($"Seats         : {dataReader["NoOfSeats"]}");
                Console.WriteLine($"Amount        : {dataReader["TotalAmount"]}");
                Console.WriteLine($"Status        : {dataReader["BookingStatus"]}");
                Console.WriteLine("-------------------------------------");
            }

            if (!found)
            {
                Console.WriteLine("Booking Id not found !");
            }
            dataReader.Close();
            conn.Close();
        }

        public void CancelTicket(int userId)
        {
            Console.WriteLine("Enter Booking Id : ");
            int bookingId = Convert.ToInt32(Console.ReadLine());

            conn = db.GetConnection();

            string query = @"SELECT ClassId,
                            NoOfSeats,
                            TotalAmount,
                            BookingStatus
                     FROM Booking
                     WHERE BookingId = @BookingId
                     AND UserId = @UserId";

            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@BookingId", bookingId);
            cmd.Parameters.AddWithValue ("@UserId", userId);

            conn.Open() ;

            dataReader = cmd.ExecuteReader();

            int classId = 0;
            int seats = 0;
            decimal totalAmount = 0;
            string status = "";

            if (dataReader.Read())
            {
                classId = Convert.ToInt32(dataReader["ClassId"]);
                seats = Convert.ToInt32(dataReader["NoOfSeats"]);
                totalAmount = Convert.ToDecimal(dataReader["TotalAmount"]);
                status = dataReader["BookingStatus"].ToString();
            }
            else
            {
                Console.WriteLine("Booking not found.");
                dataReader.Close();
                conn.Close();
                return;
            }

            if (status == "Cancelled")
            {
                Console.WriteLine("Ticket already cancelled.");
                dataReader.Close();
                conn.Close();
                return;
            }
            dataReader.Close();

            string updateBookingQuery = @"
                                        UPDATE Booking
                                        SET BookingStatus = 'Cancelled'
                                        WHERE BookingId = @BookingId";

            SqlCommand updateBookingCmd = new SqlCommand(updateBookingQuery, conn);

            updateBookingCmd.Parameters.AddWithValue(
                "@BookingId",
                bookingId);

            updateBookingCmd.ExecuteNonQuery();

            string updateSeatQuery = @"
                                        UPDATE TrainClass
                                        SET AvailableSeats = AvailableSeats + @Seats
                                        WHERE ClassId = @ClassId";

            SqlCommand updateSeatCmd =
                new SqlCommand(updateSeatQuery, conn);

            updateSeatCmd.Parameters.AddWithValue("@Seats", seats);

            updateSeatCmd.Parameters.AddWithValue("@ClassId", classId);

            updateSeatCmd.ExecuteNonQuery();

            decimal refundAmount = totalAmount * 0.80m;

            // insert cancellation

            string cancellationQuery = @"
                                        INSERT INTO Cancellation
                                        (BookingId, CancelledTicket, RefundAmount)
                                        VALUES
                                        (@BookingId, @CancelledTicket, @RefundAmount)";

            SqlCommand cancellationCmd = new SqlCommand(cancellationQuery, conn);

            cancellationCmd.Parameters.AddWithValue(
                "@BookingId",
                bookingId);

            cancellationCmd.Parameters.AddWithValue(
                "@CancelledTicket",
                seats);

            cancellationCmd.Parameters.AddWithValue(
                "@RefundAmount",
                refundAmount);

            cancellationCmd.ExecuteNonQuery();

            Console.WriteLine("\nTicket Cancelled Successfully");
            Console.WriteLine($"Refund Amount : {refundAmount}");

            conn.Close();
        }

        public void ViewCancellationDetails(int userId)
        {
            conn = db.GetConnection();

            string query = @"SELECT c.CancellationId,
                            c.BookingId,
                            td.TrainName,
                            c.CancelledTicket,
                            c.RefundAmount,
                            c.CancellationDate
                             FROM Cancellation c
                             INNER JOIN Booking b
                             ON c.BookingId = b.BookingId
                             INNER JOIN TrainDetails td
                             ON b.TrainId = td.TrainId
                             WHERE b.UserId = @UserId";

            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserId", userId);

            conn.Open();

            dataReader = cmd.ExecuteReader();

            Console.WriteLine("\n====== CANCELLED TICKETS ======\n");

            bool found = false;

            while (dataReader.Read())
            {
                found = true;
                Console.WriteLine($"Cancellation ID : {dataReader["CancellationId"]}");
                Console.WriteLine($"Booking ID      : {dataReader["BookingId"]}");
                Console.WriteLine($"Train Name      : {dataReader["TrainName"]}");
                Console.WriteLine($"Seats Cancelled : {dataReader["CancelledTicket"]}");
                Console.WriteLine($"Refund Amount   : {dataReader["RefundAmount"]}");
                Console.WriteLine($"Cancelled On    : {dataReader["CancellationDate"]}");
                Console.WriteLine("-----------------------------------");              
            }
            if (!found)
            {
                Console.WriteLine("No cancelled tickets found.");
            }
            dataReader.Close();
            conn.Close();
        }
    }
}
