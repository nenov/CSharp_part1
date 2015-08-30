using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Expressions_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number =int.Parse(Console.ReadLine()); //1234
            int first, second, third, forth;
            first = number / 1000; //1
            number = number % 1000; // 234
            second = number / 100; //2
            number = number % 100; //34
            third = number / 10; //3
            number = number % 10; //4
            forth = number;
            Console.WriteLine(first + " " + second + " " + third + " " + forth);
        }
    }
}
