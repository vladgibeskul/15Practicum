﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{/// <summary>
///  Вывести четные двузначные числа и подсчитать их количество.
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
            
            for (int x = 10; x <= 99; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                    count++;
                }
                
            }
            Console.WriteLine($"count={count}");
        }
    }
}
