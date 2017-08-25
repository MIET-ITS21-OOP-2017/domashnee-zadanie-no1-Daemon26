using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:

            double s;
            Console.WriteLine("Введите площадь окружности:");

            s = double.Parse(Console.ReadLine());
            if (s <= 0)
            {
                Console.WriteLine("Неверное значение площади окружности");
                Console.WriteLine("Введите правильное значение");
                goto begin;
            }

            double D = Math.Sqrt((s * 4) / 3.14);
            Console.WriteLine($"Диаметр Окружности равен: D = {D:00.0}см.");
            double L = 3.14 * D;
            Console.WriteLine($"Длинна окружности равна: L = {L:00.0}см.");


        }
        }
    }

