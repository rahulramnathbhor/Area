using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, a;
            Console.WriteLine("Enter radius of circle");
            r=double.Parse(Console.ReadLine());
            a = 3.14 * r * r;
            Console.WriteLine(a + "");

            
        }
    }
}
