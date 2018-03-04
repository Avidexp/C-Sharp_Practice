using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// x / y - 3
// 1 / (x + y)
// the square root of x to the 6th plus y to the 5th
// absolute value of x + y
namespace Chap6Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = -25;
            y = 12;
            Console.WriteLine(x / y - 3);
            Console.WriteLine(1 / (x + y));
            double z = Math.Sqrt((Math.Pow(x, 6) + Math.Pow(y, 5)));
            Console.WriteLine(z);
            z = Math.Abs(x + y);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
