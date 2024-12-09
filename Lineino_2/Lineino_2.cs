using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineino_2
{
    internal class Lineino_2
    {
        static void Main(string[] args)
        {
            Console.Write("y=");
            var y = int.Parse(Console.ReadLine());
            if ((0 < y) && (y < 10))
            {
                int x = 2 + y * y * y;
                Console.WriteLine(x);
                }
            else
            {
                int x = 0;
                Console.WriteLine(x);
            }

        }
    }
}
