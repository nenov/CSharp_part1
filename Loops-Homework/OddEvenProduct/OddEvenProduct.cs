using System;
class OddEvenProduct
{
    static void Main()
    {
        //You are given n integers (given in a single line, separated by a space).
        //Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
        //Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
        Console.WriteLine("Please enter a sequence of numbers, separated by a space: ");
        string nums = Console.ReadLine();
        string[] numbers = nums.Split(' ');
        long prodEven = 1;
        long prodOdd = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0) prodOdd *= int.Parse(numbers[i]);
            else prodEven *= int.Parse(numbers[i]);
        }
        if (prodOdd == prodEven) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}