﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSource
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Vasya!");            

            int A = 1;
            int B = 2;
            int C = AddAB(A, B);
            Console.WriteLine($"{A} + {B} = {C}");
            Console.ReadLine();
        }

        static int AddAB(int A, int B)
        { return A + B; }
    }
}
