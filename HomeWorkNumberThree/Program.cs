using System;

namespace HomeWorkNumberThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 1, z = 5;
            x += y - x++ * z;
            Console.WriteLine($"Переменная х ={x}, переменная y = {y}, переменная z = {z}");
            z = --x - y * 5;
            Console.WriteLine($"Переменная х ={x}, переменная y = {y}, переменная z = {z}");
            y /= x + 5 % z;
            Console.WriteLine($"Переменная х ={x}, переменная y = {y}, переменная z = {z}");
            z = x++ + y * 5;
            Console.WriteLine($"Переменная х ={x}, переменная y = {y}, переменная z = {z}");
            x = y - x++ * z;
            Console.WriteLine($"Переменная х ={x}, переменная y = {y}, переменная z = {z}");

        }
    }
}
