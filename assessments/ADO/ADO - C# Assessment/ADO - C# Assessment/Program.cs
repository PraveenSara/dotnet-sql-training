using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO___C__Assessment
{
    internal class Program
    {
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader dr = null;

        static void Main(string[] args)
        {
            SelectData();
            Console.WriteLine("---------------------------");        
            InsertData();
            Console.WriteLine("---------After changes-----------");
            SelectData();

            Console.Read();
        }

        // INSERT USING STORED PROCEDURE
        static void InsertData()
        {
            try
            {
                conn = getConnection();

                Console.Write("Enter Employee Name:");
                string empname = Console.ReadLine();

                Console.Write("Enter Employee Salary:");
                decimal empsal = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter Employee Type (f/p):");
                string emptype = Console.ReadLine();

                cmd = new SqlCommand("sp_insertEmployees", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@empname", empname);
                cmd.Parameters.AddWithValue("@empsal", empsal);
                cmd.Parameters.AddWithValue("@emptype", emptype);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                    Console.WriteLine("Record inserted successfully...");
                else
                    Console.WriteLine("Insert failed...");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
        }

        // SELECT DATA 
        public static void SelectData()
        {
            try
            {
                conn = getConnection();
                cmd = new SqlCommand("select * from employee_details", conn);
                dr = cmd.ExecuteReader();

                Console.WriteLine("\nEmployee Details:");
                Console.WriteLine("---------------------------");

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
