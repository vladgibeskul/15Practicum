using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
///  Одна штука некоторого товара стоит 20,4 руб. Напечатать таблицу стоимости 2, 3, ..., 20 штук этого товара.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        public static void Func()
        {
            double price = 20.4;
            for (int i = 2; i <= 20; i++)
            {
                Console.WriteLine($"{i}-ий.={price * i}руб");
            }
        }
    }
}
