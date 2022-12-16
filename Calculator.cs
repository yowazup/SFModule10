using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModule10
{
    public interface ICalculator
    {
        public void Sum(int a, int b);
    }

    public class SumCalculator : ICalculator
    {
        ILogger Logger { get; }

        public SumCalculator(ILogger logger)
        {
            Logger = logger;
        }

        void ICalculator.Sum(int a, int b)
        {
            int c = a + b;

            Console.WriteLine();
            Logger.Event("Приступаю к расчету...пару секунд.");
            Thread.Sleep(2000);
            Logger.Event("Расчет окончен.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Рузультат получился такой: {0}", c);
        }
    }
}
