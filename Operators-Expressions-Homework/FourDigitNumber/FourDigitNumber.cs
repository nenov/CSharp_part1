using System;
class FourDigitNumber
{
    static void Main()
    {
        int number;
        number = int.Parse(Console.ReadLine());
        int first, second, third, forth;
        first = number / 1000; 
        number = number % 1000;
        second = number / 100; 
        number = number % 100; 
        third = number / 10; 
        number = number % 10;
        forth = number;
        Console.WriteLine("The sum of the digits is: " + ( first + second + third+ forth));
        Console.WriteLine("The number in reversed order is:{3}{2}{1}{0}",first,second,third,forth);
        Console.WriteLine("The number with the first digit put in the beginning:{3}{0}{1}{2}", first, second, third, forth);
        Console.WriteLine("The number with exchanged second and third digit:{0}{2}{1}{3}", first, second, third, forth);
    }
}
