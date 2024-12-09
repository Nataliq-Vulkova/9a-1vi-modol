using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineino
{
    internal class Lineino
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
            else if (y >= 10)
            {
                int x = 0;
                Console.WriteLine(x);
            }

        }
    }
}
