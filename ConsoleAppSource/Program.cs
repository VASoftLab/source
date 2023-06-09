using System;
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
            
            Console.WriteLine($"{A} + {B} = {AddAB(A, B)}");
            Console.WriteLine($"{A} * {B} = {MultAB(A, B)}");
            Console.WriteLine($"{A} / {B} = {DivAB(A, B)}");

            Console.ReadLine();
        }

        static int AddAB(int A, int B)
        { return A + B; }

        static int MultAB(int A, int B)
        { return A * B; }
        
        static double DivAB(int A, int B)
        { return (double)A / (double)B; }
    }
}
