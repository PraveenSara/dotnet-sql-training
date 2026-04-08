using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    internal class Product
    {
        int ProductId;
        string Name;
        double Price;
        public void ProductList()
        {
            Product[] product = new Product[10];

            for (int i = 0; i < 10; i++)
            {
                product [i] = new Product();
                Console.WriteLine("Enter details for product " + i + 1);

                Console.Write("Enter Product name : ");
                product[i].Name = Console.ReadLine();
                Console.Write("Enter Product Id : ");
                product[i].ProductId = int.Parse(Console.ReadLine());
                Console.Write("Enter Product Price : ");
                product[i].Price = Convert.ToDouble(Console.ReadLine());

            }
            Array.Sort(product, (p1, p2) => p1.Price.CompareTo(p2.Price));

            Console.WriteLine("\nProducts sorted by Price:\n");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Product Id : " + product[i].ProductId);
                Console.WriteLine("Product Name : " + product[i].Name);
                Console.WriteLine("Product Price : " + product[i].Price);
                Console.WriteLine("------------------------");
            }
        }
    }
}
