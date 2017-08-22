using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:
            Console.WriteLine("Введите значение длины окружности: ");
                double L;
                           
            L = double.Parse(Console.ReadLine());
            if (L < 0)
            {
                Console.WriteLine("Неверное значение Длины окружности");
                goto begin;
            }         
            double R = L / 3.14 / 2;
            Console.WriteLine($"Радиус окружности равен: {R:0.00} см.");
            double S = 3.14 * R * R;
            Console.WriteLine($"Площадь окружности равна: {S:0.00} кв.см.");


        }
    }
}
