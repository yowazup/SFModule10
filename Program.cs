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

        /// <summary>
        /// Программа, которая запрашивает на ввод 2 слагаемых (от -100 до 100) (метод Main), проверяет корректность 
        /// ввода информации и выводит исключения (Check.cs), логирует событие начала и окончания расчета (Logger.cs), 
        /// производит расчет и выводит их сумму в консоль (Calculator.cs).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Добро пожаловать в калькулятор суммы двух целых чисел от -100 до 100.");


            Console.WriteLine("Сообщите первое число:");

            int a;
            var check = Console.ReadLine();

            Check.While(check, out a);

            Console.WriteLine();
            Console.WriteLine("Сообщите второе число:");

            int b;
            check = Console.ReadLine();

            Check.While(check, out b);

            Console.WriteLine();

            Logger = new Logger();
            var sum = new SumCalculator(Logger);

            ((ICalculator)sum).Sum(a, b);

            Console.ReadKey();
        }

    }
}