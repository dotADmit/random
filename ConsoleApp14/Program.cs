using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер таблицы по ширине: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите размер таблицы по высоте: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int count = 1;
            int paint = 1;
            int paint2 = width;
            Random rnd = new Random();

            for (int i = 1; i <= width * height; i++)
            {
                Console.ResetColor();
                int number = rnd.Next(1, width * height);

                if (i == paint && i <= width * width)
                {
                    paint += width + 1;
                    Console.BackgroundColor = ConsoleColor.Gray;
                }

                if (i == paint2 && i <= width * width)
                {
                    paint2 += width - 1;
                    Console.BackgroundColor = ConsoleColor.Gray;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;

                if (number % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write($"{number,4}");

                if (i % width * count == 0)
                {
                    count++;
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
