using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practisingLambda_Linq
{
    class Program
    {
        static T DoAnythingWith2params<T>(ref T a, T b, Func<T, T, T> myDelegate)
        {
            return myDelegate(a,b);
        }

        static void Main(string[] args)
        {
            Func<int, int, int> sum = (a, b) => a + b;
            //Console.WriteLine("Expressing literally: {0}", sum(3, 2));

            Func<double, double> squareAreaCalc = (side) => side * side;

            Func<double, double, double> genericOne = (x, y) => (x + x) * y;

            Console.WriteLine("Calling a method: {0}", squareAreaCalc(2.2));

            Console.ReadKey();
        }
    }
}
