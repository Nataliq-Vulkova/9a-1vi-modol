using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlagane
{
    internal class vlagane
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно число");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Въведи един плод или зеленчук");
            var b = (Console.ReadLine());
            Console.Write("Какво си въвел");
            var c = (Console.ReadLine());

            if (b == "plod")
            {
                if (a == 2)
                    Console.WriteLine("Ти си въвел плод с име " + b + " Цветът му е жълт");
                else
               if (a == 3)
                    Console.WriteLine("Ти си въвел плод с име " + b + " Цветът му е зелен");
                else

                if (a == 4)
                    Console.WriteLine("Ти си въвел плод с име " + b + " Цветът му е`червен");
                else

                if (a == 5)
                    Console.WriteLine("Ти си въвел плод с име " + b + " Цветът му е`лилаво");
                else

                if (a == 6)
                    Console.WriteLine("Ти си въвел плод с име " + b + " Цветът му е`кафяво");
            }


            else
            {
                if (a == 2)
                    Console.WriteLine("Ти си въвел зеленчук с име " + b + " Цветът му е жълт");
                else
if (a == 3)
                    Console.WriteLine("Ти си въвел зеленчук с име " + b + " Цветът му е зелен");
                else

if (a == 4)
                    Console.WriteLine("Ти си въвел зеленчук с име " + b + " Цветът му е`червен");
                else

if (a == 5)
                    Console.WriteLine("Ти си въвел зеленчук с име " + b + " Цветът му е`лилаво");
                else

if (a == 6)
                    Console.WriteLine("Ти си въвел зеленчук с име " + b + " Цветът му е`кафяво");

            }
        }
    }
}
