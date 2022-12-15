using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModule10
{
    public class Check
    {

        public static void TryCatch(string item)
        {

            try
            {
                if (String.IsNullOrWhiteSpace(item))
                {
                    throw new ArgumentNullException();
                }
                else if (!int.TryParse(item, out int result))
                {
                    throw new FormatException();
                }
                else if (result < -100 || result > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Пользователь ввел пустое значение. {0}", ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Пользователь ввел не целое число формата integer. {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Пользователь ввел число вне диапазона от -100 до 100. {0}", ex.Message);
            }
        }

    }
}
