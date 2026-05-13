using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_updation
{
    internal class Program
    {
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader dr = null;

        static void Main(string[] args)
        {
            SelectData();
            Console.WriteLine("-----------------------------");
            UpdateSalary();
            Console.WriteLine("\n-------------After updation------------");
            SelectData();

            Console.Read();
        }

        static void UpdateSalary()
        {
            try
            {
                conn = getConnection();

                Console.WriteLine("Enter Employee Id:");
                int empid = Convert.ToInt32(Console.ReadLine());

                cmd = new SqlCommand("sp_updatesalary", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@empid", empid);

                SqlParameter outParam = new SqlParameter();
                outParam.ParameterName = "@updatedsalary";
                outParam.SqlDbType = SqlDbType.Decimal;
                outParam.Direction = ParameterDirection.Output;
                outParam.Precision = 10;
                outParam.Scale = 2;

                cmd.Parameters.Add(outParam);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Updated Salary: " + outParam.Value);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

     
        public static void SelectData()
        {
            try
            {
                conn = getConnection();

                cmd = new SqlCommand("select * from employee_details", conn);

                dr = cmd.ExecuteReader();

                Console.WriteLine("\nEmployee Details:");
                Console.WriteLine("-----------------------------");

                while (dr.Read())
                {
                    Console.WriteLine($"{dr["empno"]} {dr["empname"]} {dr["empsal"]} {dr["emptype"]} ");
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static SqlConnection getConnection()
        {
            conn = new SqlConnection(
                "data source = ICS-LT-48QTHT3\\SQLEXPRESS; initial catalog = Employeemanagement; integrated security = true;");

            conn.Open();
            return conn;
        }
    }
}
