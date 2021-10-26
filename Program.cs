using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double k;
            Console.Write("Введите свою оценку = ");
            k = Convert.ToDouble(Console.ReadLine());
            {
                switch (k)
                {
                    case 1:
                        Console.Write("Плохо");
                        break;
                    case 2:
                        Console.Write("Неудовлетворительно");
                        break;
                    case 3:
                        Console.Write("Удовлетворительно");
                        break;
                    case 4:
                        Console.Write("Хорошо");
                        break;
                    case 5:
                        Console.Write("Отлично");
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                Console.ReadKey();

            }
        }
    }
}
