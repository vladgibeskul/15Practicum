using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{/// <summary>
/// Генерируются 10 случайных целых чисел в интервале (-40, 40). Вывести эти числа.
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
            Random random = new Random();
            for (int i = 0; i<10; i++)
            {
                int number=random.Next(-40,40);
                Console.WriteLine(number);
            }
        }

    }
}
