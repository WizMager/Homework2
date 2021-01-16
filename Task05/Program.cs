using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
    //   б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

    class Program
    {
        static void Main(string[] args)
        {
            double height, weigth;
            Console.WriteLine("Подсчёт индекса массы тела.");
            Console.Write("Введите ваш рост, см: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш вес, кг: ");
            weigth = double.Parse(Console.ReadLine());
            //Console.Clear();

            Console.WriteLine("Ваш ИМТ равен: {0:f3}.", BodyMassIndex(height, weigth)); //Task 5.1
            //Console.ReadKey();
            BmiNormalize(BodyMassIndex(height, weigth), height); //Task5.2
            Console.ReadKey();
        }

        #region Task5.1
        static double BodyMassIndex(double height, double weight)
        {
            double bmi;
            bmi = weight / Math.Pow(height / 100, 2);
            return bmi;
        }
        #endregion

        #region Task5.2
        static void BmiNormalize(double bmi, double height)
        {
            double tempBMI, weight;
            if(bmi <= 18.5)
            {
                tempBMI = bmi - 18.5;
                weight = -tempBMI * Math.Pow(height / 100, 2);
                Console.WriteLine("Вам нужно набрать {0:f2}кг.", weight);
            } else if(bmi >= 25)
            {
                tempBMI = bmi - 25;
                weight = tempBMI * Math.Pow(height / 100, 2);
                Console.WriteLine("Вам нужно сбросить {0:f2}кг.", weight);
            }
            else
            {
                Console.WriteLine("Ваш индекс массы тела находится в пределах от 18.5 до 25, что является нормой.");
            }

        }
        #endregion


    }
}
