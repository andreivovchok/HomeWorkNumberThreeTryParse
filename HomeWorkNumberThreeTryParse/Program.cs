using System;

namespace HomeWorkNumberThreeTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            int formingPart;
            const double PI = 3.141;

            while (true)
            {
                Console.WriteLine("Введите целочисленное значение радиус основания");
                if (int.TryParse(Console.ReadLine(), out radius))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное число, попробуйте еще раз");
                }
            }
            while (true)
            {
                Console.WriteLine("Введите целочисленное значение образующей");
                if (int.TryParse(Console.ReadLine(), out formingPart))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное число, попробуйте еще раз");
                }
            }

            double S = PI * radius * (radius + formingPart);
            Console.WriteLine(S);

            Console.ReadKey();
        }
    }
}
