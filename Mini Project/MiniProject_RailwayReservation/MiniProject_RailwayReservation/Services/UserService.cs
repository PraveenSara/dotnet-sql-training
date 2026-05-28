using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject_RailwayReservation.DB;


namespace MiniProject_RailwayReservation.Services
{
    internal class UserService
    {
        DbConnection db = new DbConnection();
        TrainService trainService = new TrainService();

        public void Register()
        {
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your email : ");
            string email = Console.ReadLine();

            Console.Write("Enter password : ");
            string password = Console.ReadLine();

            SqlConnection conn = db.GetConnection();

            string query = @"insert into Users (FullName, Email, Password, Role) values (@FullName, @Email, @Password, 'User')";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Fullname", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                Console.WriteLine("Registration Successfull.");
            }
            else
            {
                Console.WriteLine("Registration failed");
            }
        }

        public void Login()
        {
            Console.Write("Enter your Email : ");
            string email = Console.ReadLine();

            Console.Write("Enter your Password : ");
            string password = Console.ReadLine();

            SqlConnection conn = db.GetConnection();

            string query = @"select UserId, Fullname, Role from Users where Email = @Email and Password = @Password";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Email", email);
            cmd.Parameters.AddWithValue("Password", password);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int userId = Convert.ToInt32(reader["UserId"]);
                string fullName = reader["FullName"].ToString();
                string role = reader["Role"].ToString();

                Console.WriteLine($"Welcome {role} {fullName}");

                if (role == "Admin")
                {
                    AdminMenu();
                }
                else
                {
                    UserMenu(userId);
                }
            }

            else
            {
                Console.WriteLine("Login failed : Invalid username and password");
            }
        }

        public void AdminMenu()
        {
            Console.WriteLine("\n---------  WELCOME TO ADMIN PAGE  -------------");
            Console.WriteLine("\n1. Add Train.\n2. View Train.\n3. Update Train.\n4. Delete Train.");

            Console.WriteLine("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    trainService.AddTrain();
                    break;
                case 2:
                    trainService.ViewTrain();
                    break;
                case 3:
                    trainService.UpdateTrain();
                    break;
                case 4:
                    trainService.DeleteTrain();
                    break;
                default:
                    Console.WriteLine("Invalid choice enter (1/2/3/4) only.");
                    break;
            }
        }

        public void UserMenu(int userId)
        {
            Console.WriteLine("\n---------  WELCOME TO USER MENU PAGE  -------------");
            Console.WriteLine("\n1. Search Train.\n2. Book Ticket.\n3. View Ticket.\n4. Cancel Ticket.");

            Console.WriteLine("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                // TODO : Create functions for UserMenu
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid choice enter (1/2/3/4) only.");
                    break;
            }
        }
    }
}
