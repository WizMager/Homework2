using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    //4. Реализовать метод проверки логина и пароля.
    //На вход подается логин и пароль.На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    //С помощью цикла do while ограничить ввод пароля тремя попытками.

    
    class Program
    {
        static void Main(string[] args)
        {
            string login, password;
            int count = 3;

            do
            {
                Console.WriteLine($"Введите логин и пароль. У вас есть {count} попыток.");
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();

                if(Autorization(login, password))
                {
                    Console.Clear();
                    Console.WriteLine("Вы ввели верный логин и пароль.");
                    break;
                } else
                {
                    Console.Clear();
                    Console.WriteLine("Вы ввели неверный логин и/или пароль.");
                    count--;
                }

            } while (count > 0);

            Console.ReadKey();
        }

        static bool Autorization(string login, string pass)
        {
            bool isAutorized = false;
            if (login == "root" && pass == "GeekBrains")
                isAutorized = true;
            return isAutorized;
        }
    }
}
