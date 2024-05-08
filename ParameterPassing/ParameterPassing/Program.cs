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
            int i = 10;
            Console.WriteLine($"Before Calling Increment: {i}");
            Increment(i);
            Console.WriteLine($"After Calling Increment: {i}");
        }

        private static void Increment(int i)
        {
            Console.WriteLine($"Before increment: {i}");
            i = i + 1;
            Console.WriteLine($"After increment: {i}");
        }
    }
}
