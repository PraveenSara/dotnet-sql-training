using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class SaleDetails
    {
        int salesNo;
        int productNo;
        double price;
        int qty;
        string dateOfSale;
        double totalAmount;
        public SaleDetails(int sNo, int pNo, double pr, int q, string date)
        {
            salesNo = sNo;
            productNo = pNo;
            price = pr;
            qty = q;
            dateOfSale = date;
        }
        public void Sales()
        {
            totalAmount = qty * price;
        }
        public static void ShowData(SaleDetails s)
        {
            Console.WriteLine("\nSales Details:");
            Console.WriteLine("Sales No: " + s.salesNo);
            Console.WriteLine("Product No: " + s.productNo);
            Console.WriteLine("Price: " + s.price);
            Console.WriteLine("Quantity: " + s.qty);
            Console.WriteLine("Date of Sale: " + s.dateOfSale);
            Console.WriteLine("Total Amount: " + s.totalAmount);
        }
    }
}
