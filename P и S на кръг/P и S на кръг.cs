using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_и_S_на_кръг
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r=");
            var r= double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            Console.WriteLine(Math.Round (area, 2));
            var perimeter= 2 * Math.PI * r;
            Console.WriteLine(Math.Round(perimeter, 2));
        }
    }
}
