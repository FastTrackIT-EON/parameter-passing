using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterPassing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine($"Before Calling Increment: {x}");
            Increment(x);
            Console.WriteLine($"After Calling Increment: {x}");

            Console.WriteLine("--------------");

            Product prod = new Product();
            prod.Id = 1;
            prod.Name = "Product ABC";

            Console.WriteLine($"Before Calling ChangeProductName: {prod.Name}");
            ChangeProductName(prod);
            Console.WriteLine($"After Calling ChangeProductName: {prod.Name}");

            Console.ReadKey();
        }

        private static void Increment(int i)
        {
            Console.WriteLine($"Before increment: {i}");
            i = i + 1;
            Console.WriteLine($"After increment: {i}");
        }

        private static void ChangeProductName(Product p)
        {
            Console.WriteLine($"Before change product name: {p.Name}");
            // p.Name = "Changed Name";
            p = new Product();
            p.Name = "Changed Name";
            Console.WriteLine($"After change product name: {p.Name}");
        }
    }
}
