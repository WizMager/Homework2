using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    //6. * Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
    //Хорошим называется число, которое делится на сумму своих цифр.
    //Реализовать подсчет времени выполнения программы, используя структуру DateTime.
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine("Начало расчёта: {0:T}.", start);
            int countNum = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (i / SumNumber(i) % 2 == 0)
                    countNum++;
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine("Конец расчёта: {0:T}.", finish);
            Console.WriteLine("Общее время, затраченное на расчёт: {0}", finish - start);
            Console.WriteLine($"В диапазоне чисел от 1 до 1 000 000 000 \"хороших\" чисел\n(числа, которые делятся на сумму своих цифр без остатка): {countNum}");
            Console.ReadKey();
        }

        static int SumNumber(int number)
        {
            int sumNum = 0;
            string strNumber = Convert.ToString(number);
            foreach(char ch in strNumber)
            {
                sumNum += Convert.ToInt32(ch);
            }
            return sumNum;
        }
    }
}
