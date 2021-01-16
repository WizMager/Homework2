using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
    //   б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            Console.WriteLine("Введите 2 целых числа(первое меньше второго).");
            Console.Write("Введите первое число: ");
            first = int.Parse(Console.ReadLine());
            Console.Write($"Введите второе число(первое число равно {first}): ");
            second = int.Parse(Console.ReadLine());
            Console.Clear();

            RekursWriteNumbers(first, second); //Task7.1
            Console.ReadKey();

            Console.WriteLine("Сумма чисел от {0} до {1} равна {2}.", first, second, RekursSumNumber(first, second)); //Task7.2
            Console.ReadKey();

        }

        #region Task7.1
        static void RekursWriteNumbers(int frst, int scnd)
        {
            if (frst <= scnd)
            {
                Console.Write($"{frst} ");
                frst++;
                RekursWriteNumbers(frst, scnd);
            }
        }
        #endregion

        #region Task7.2
        static int RekursSumNumber(int first, int second)
        {
            if (first == second)
            {
                return first;
            } else
            {
                return first + RekursSumNumber(first + 1, second);
            }
            
        }
        #endregion
    }
}
