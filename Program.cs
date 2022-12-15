using System;
using System.IO;
using System.Globalization;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Security.AccessControl;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Net.Security;
using System.Data.Common;

namespace SFModule10
{
    public class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {

            Console.WriteLine("Добро пожаловать в калькулятор суммы двух целых чисел от -100 до 100.");


            Console.WriteLine("Сообщите первое число:");

            int a;
            var check = Console.ReadLine();

            while (!int.TryParse(check, out a) || a > 100 || a < -100)
            {
                Check.TryCatch(check);
                Console.WriteLine();
                Console.WriteLine("Вы ввели неверное значение. Ответ должен быть целым числом от -100 до 100. Введите правильное значение: ");
                check = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Сообщите второе число:");

            int b;
            check = Console.ReadLine();

            while (!int.TryParse(check, out b) || b > 100 || b < -100)
            {
                Check.TryCatch(check);
                Console.WriteLine();
                Console.WriteLine("Вы ввели неверное значение. Ответ должен быть целым числом от -100 до 100. Введите правильное значение: ");
                check = Console.ReadLine();
            }

            Console.WriteLine();

            Logger = new Logger();
            var sum = new SumCalculator(Logger);

            ((ICalculator)sum).Sum(a, b);

            Console.ReadKey();
        }

    }
}