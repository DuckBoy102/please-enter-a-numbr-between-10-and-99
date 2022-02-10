using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a numbr between 10 and 99");
            int x;
            x = int.Parse(Console.ReadLine());
            int y;
            y = (x / 10);
            int z;
            z = (x % 10);
            if (y == z)
                Console.WriteLine("OK");
            else 
                Console.WriteLine("Error");
        }
    }
}
