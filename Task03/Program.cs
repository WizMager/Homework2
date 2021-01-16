using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber;
            double result = 0;
            do
            {
                Console.Write("Введите число не равное 0(0 - конец ввода): ");
                inputNumber = double.Parse(Console.ReadLine());
                if (inputNumber % 2 != 0 & inputNumber > 0)
                {
                    result += inputNumber;
                }
            } while (inputNumber != 0);

            Console.Clear();
            Console.WriteLine($"Сумма нечётных положительных чисел равна: {result}.");
            Console.ReadKey();
        }
    }
}
