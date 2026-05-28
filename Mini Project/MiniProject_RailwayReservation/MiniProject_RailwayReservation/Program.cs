using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject_RailwayReservation.DB;
using MiniProject_RailwayReservation.Services;

namespace MiniProject_RailwayReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            Console.WriteLine("----------------  WELCOME TO RAILWAY PORTAL  ----------------\n");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");

            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    userService.Register();
                    break;

                case 2:
                    userService.Login();
                    break;

                default:
                    Console.WriteLine("Enter numeric value 1/2");
                    break;
            }

            Console.ReadLine();
        }
    }
}
