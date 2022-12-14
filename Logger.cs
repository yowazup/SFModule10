using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModule10
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);

    }

    public class Logger : ILogger
    {

        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

}
