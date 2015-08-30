using System;
class CheckBitGivenPosition
{
    static void Main()
    {
        //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
        //in given integer number n, has value of 1
        Console.WriteLine("Please enter an integer: ");
        int enteredNumber = int.Parse(Console.ReadLine());
        int mask = 1;
        Console.WriteLine("Please enter the position of the bit: ");
        int index = int.Parse(Console.ReadLine());
        mask = mask << index;
        bool result= ((enteredNumber & mask) >> index) == 1 ? true : false;
        Console.WriteLine(result);
    }
}