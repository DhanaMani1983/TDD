﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Library;
namespace TDDExample
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i < 100; i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }

            Console.ReadLine();
        }
    }
}
