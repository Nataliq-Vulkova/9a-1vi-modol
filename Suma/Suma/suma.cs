using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    internal class suma
    {
        static void Main(string[] args)
        {
         
            Console.Write("a=");
            double a=double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b=double.Parse(Console.ReadLine());
            double c= a + b;
            Console.WriteLine("c="+c);
            Console.WriteLine("c={0}" ,c);
            Console.WriteLine("Сумата на a+b е:" + c);
            Console.WriteLine($"Сумата на a+b е: {c}");

            


        }
    }
}
