using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Ahahhaha");

            Console.WriteLine("5+2= " + Sum.method(5, 2));
            Console.WriteLine("5-2= " + Sub.method(5, 2));

            Console.ReadKey();
        }
    }
}
