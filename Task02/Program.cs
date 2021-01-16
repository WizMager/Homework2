using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    //2. Написать метод подсчета количества цифр числа.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для подсчёта его цифр: ");
            string number = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("В числе {0} находится цифр: {1}.", number, NuberCount(number));
            Console.ReadKey();
        }

        static int NuberCount(string number)
        {
            int count = 0;
            foreach(char num in number)
            {
                if (num == ',' || num == '.')
                    continue;
                count++;
            }
            return count;
        }
    }
}
