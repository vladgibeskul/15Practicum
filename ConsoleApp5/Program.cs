using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{/// <summary>
/// Генерируются 15 случайных целых чисел в интервале (-20, 30). Вывести эти числа и подсчитать количество положительных чисел.
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
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                int number = random.Next(-20,30);
                Console.WriteLine(number);
                if (number > 0) count++;
            }
            Console.WriteLine($"количество положительных чисел: {count}");
        }

    }
}
