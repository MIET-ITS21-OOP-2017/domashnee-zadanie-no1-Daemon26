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
            Console.WriteLine("Введите значение длинны окружности: ");
                double L;
                           
            L = double.Parse(Console.ReadLine());
            if (L < 0)
            {
                Console.WriteLine("Неверное значение Длинны окружности");
                goto begin;
            }
         
            double R = 2 * 3.14 * L;
            Console.WriteLine($"Радиус окружности равен: {R} см.");
            double S = 3.14 * R * R;
            Console.WriteLine($"Площадь окружности равна: {S} кв.см.");


        }
    }
}
