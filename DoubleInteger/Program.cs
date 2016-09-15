using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer between (1-100): ");
            int integer = int.Parse(Console.ReadLine());
            Console.WriteLine("Double {0} is {1}", integer, Double(integer));
        }
        static int Double(int integer)
        {
            int dblInteger = integer * 2;
            return dblInteger;
        }
    }
}
