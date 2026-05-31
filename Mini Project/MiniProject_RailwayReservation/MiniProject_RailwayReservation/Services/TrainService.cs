using MiniProject_RailwayReservation.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace MiniProject_RailwayReservation.Services
{
    internal class TrainService
    {
        DbConnection db = new DbConnection();

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dataReader = null;
        public void AddTrain()
        {
            try
            {
                Console.Write("Enter Train Number : ");
                string trainNo = Console.ReadLine();

                Console.Write("Enter Train Name : ");
                string trainName = Console.ReadLine();

                Console.Write("Enter Source : ");
                string source = Console.ReadLine();

                Console.Write("Enter destination : ");
                string destination = Console.ReadLine();

                Console.Write("Enter departure (yyyy-MM-dd HH:mm) : ");
                DateTime departure = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter Arrival (yyyy-MM-dd HH:mm) : ");
                DateTime arrival = Convert.ToDateTime(Console.ReadLine());

                conn = db.GetConnection();
                string query = @"insert into TrainDetails (TrainNumber, TrainName, Source, Destination, Departure, Arrival)
                                             values (@TrainNo, @TrainName, @Source, @Destination, @Departure, @Arrival)";
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TrainNo", trainNo);
                cmd.Parameters.AddWithValue("@TrainName", trainName);
                cmd.Parameters.AddWithValue("@Source", source);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.Parameters.AddWithValue("@Departure", departure);
                cmd.Parameters.AddWithValue("@Arrival", arrival);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Console.WriteLine("Train Added Successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to Add Train");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ViewTrain()
        {
            try
            {
                conn = db.GetConnection();
                string query = "Select * from TrainDetails ";

                cmd = new SqlCommand(query, conn);

                conn.Open();

                dataReader = cmd.ExecuteReader();

                Console.WriteLine("TrainId\tTrainNumber\tTrainName\t\tFrom\tTo\tDeparture\tArrival\tIsCancelled");

                while (dataReader.Read())
                {
                    Console.WriteLine($"{dataReader["TrainId"]}\t{dataReader["TrainNumber"]}\t\t{dataReader["TrainName"]}\t\t{dataReader["Source"]}\t{dataReader["Destination"]}\t{dataReader["Departure"]}\t{dataReader["Arrival"]}\t{dataReader["IsCancelled"]}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateTrain()
        {
            try
            {
                conn = db.GetConnection();
                Console.Write("Enter Train Id : ");
                int trainId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Train Number : ");
                string trainNo = Console.ReadLine();

                Console.Write("Enter New Train Name : ");
                string trainName = Console.ReadLine();

                Console.Write("Enter New Source : ");
                string source = Console.ReadLine();

                Console.Write("Enter New Destination : ");
                string destination = Console.ReadLine();

                Console.Write("Enter New Departure : ");
                string departure = Console.ReadLine();

                Console.Write("Enter New Arrival : ");
                string arrival = Console.ReadLine();

                string query = @"Update TrainDetails set TrainNumber = @TrainNo, TrainName = @TrainName, Source = @Source, Destination = @Destination, Departure = @Departure, Arrival = @Arrival where TrainId = @TrainId";
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("TrainId", trainId);
                cmd.Parameters.AddWithValue("@TrainNo", trainNo);
                cmd.Parameters.AddWithValue("@TrainName", trainName);
                cmd.Parameters.AddWithValue("@Source", source);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.Parameters.AddWithValue("@Departure", departure);
                cmd.Parameters.AddWithValue("@Arrival", arrival);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Console.WriteLine("Update successfull.");
                }
                else
                {
                    Console.WriteLine("Update Failed");
                }

                Console.WriteLine("\n-------------- Updated Train Details --------------\n");
                ViewTrain();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteTrain()
        {
            try
            {
                conn = db.GetConnection();
                Console.Write("Enter the Train Number to Cancel : ");
                string trainNo = Console.ReadLine();

                string query = @"Update TrainDetails set IsCancelled = 1 where TrainNumber = @TrainNumber";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrainNumber", trainNo);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Console.WriteLine($"Train Number : {trainNo} is cancelled");
                }
                else
                {
                    Console.WriteLine($"Something went wrong - Train Number : {trainNo} not cancelled");
                }
                Console.WriteLine("\n-------------- Updated Train Details --------------\n");
                ViewTrain();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // ----------------------  User Menus  -------------------------------------

        public void SearchTrain()
        {
            conn = db.GetConnection();

            Console.Write("Enter Source : ");
            string source = Console.ReadLine();

            Console.Write("Enter Destination : ");
            string destination = Console.ReadLine();

            string query = @"select td.TrainId, td.TrainNumber, td.TrainName, tc.ClassId, tc.ClassName, tc.AvailableSeats, tc.Fare
                                From TrainDetails td inner Join TrainClass tc
                                on td.TrainId = tc.TrainId
                                where td.Source = @Source and td.Destination = @Destination and IsCancelled = 0";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Source", source);
            cmd.Parameters.AddWithValue("@Destination", destination);

            conn.Open();

            dataReader= cmd.ExecuteReader();

            int currentTrainId = -1;

            Console.WriteLine($"\n---------  Available Trains for  :  {source} -- {destination}  ---------");

            while (dataReader.Read())
            {
                int trainId = Convert.ToInt32(dataReader["TrainId"]);

                if (currentTrainId != trainId)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Train ID   : {dataReader["TrainId"]}");
                    Console.WriteLine($"Train No   : {dataReader["TrainNumber"]}");
                    Console.WriteLine($"Train Name : {dataReader["TrainName"]}");
                    Console.WriteLine();

                    currentTrainId = trainId;
                }

                Console.WriteLine($"Class ID        : {dataReader["ClassId"]}");
                Console.WriteLine($"Class           : {dataReader["ClassName"]}");
                Console.WriteLine($"Available Seats : {dataReader["AvailableSeats"]}");
                Console.WriteLine($"Fare            : {dataReader["Fare"]}");
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------------");

            conn.Close();


        }
    }
}
