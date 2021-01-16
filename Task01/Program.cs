using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    //1. Написать метод, возвращающий минимальное из трех чисел.
    //Островский Антон
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, third;
            Console.WriteLine("Введите 3 числа.");
            Console.Write("Введите первое число: ");
            first = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            second = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            third = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Минимальное число из {0}, {1}, {2} равно {3}.", first, second, third, MinNumber(first, second, third));
            Console.ReadKey();
        }

        static double MinNumber(double frst, double scnd, double thrd)
        {
            double result = frst;
            if(result > scnd)
                result = scnd;
            if (result > thrd)
                result = thrd;
            return result;
        }
    }
}
