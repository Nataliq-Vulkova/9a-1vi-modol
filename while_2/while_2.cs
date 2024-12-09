using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_2
{
    internal class while_2
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            var n = int.Parse(Console.ReadLine());
            int num = 1;
            while (num <= n)
            {
                num++;//2

                if (num % 2 == 0)
                {
                    Console.WriteLine(num++);//2
                }
            }


        }
    }
}
