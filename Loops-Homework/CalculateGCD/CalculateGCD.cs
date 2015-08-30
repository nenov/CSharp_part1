using System;
class CalculateGCD
{
    static void Main()
    {
        //Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
        //Use the Euclidean algorithm (find it in Internet).
        Console.WriteLine("Please enter the first integer:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second integer:");
        int second = int.Parse(Console.ReadLine());
        int larger;
        int smaller;
        if (first > second)
        {
            larger = first;
            smaller = second;
        }
        else
        {
            larger = second;
            smaller = first;
        }
        //If A = 0 then GCD(A,B)=B, since the GCD(0,B)=B, and we can stop.  
        //If B = 0 then GCD(A,B)=A, since the GCD(A,0)=A, and we can stop.  
        //Write A in quotient remainder form (A = B⋅Q + R)
        //Find GCD(B,R) using the Euclidean Algorithm since GCD(A,B) = GCD(B,R)
        if (first == 0) Console.WriteLine(second);
        else if (second == 0) Console.WriteLine(first);
        int middle;
        while (larger != 0 && smaller != 0)
        {
            middle = larger % smaller;
            larger = smaller;
            smaller = middle;
        }
        Console.WriteLine(larger);
    }
}