using System;
class CalculateProblem5
{
    static void Main()
    {
        //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
        //Use only one loop. Print the result with 5 digits after the decimal point.
        Console.WriteLine("Please enter first integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second integer number: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        long fact=1;
        for (int i = 1; i <= n; i++)
			{
             fact = fact*i;
			 sum=sum + (fact/ (Math.Pow(x,i)));
			}
        Console.WriteLine("{0:F5}", sum);
    }
}