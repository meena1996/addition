using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result;
            Console.WriteLine("Enter a value");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value");
            b = Convert.ToInt32(Console.ReadLine());
            result = a + b;
            Console.WriteLine("The sum is={0}", result);
            Console.ReadKey();
        }
    }
}
