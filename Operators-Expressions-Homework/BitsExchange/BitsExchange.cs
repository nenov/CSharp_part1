using System;
class BitsExchange
{
    static void Main()
    {
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
        Console.WriteLine("Please enter a unsigned integer: ");
        uint enteredNumber = uint.Parse(Console.ReadLine());
        //checking the bits at the positions
        uint mask = 1;
        int[] index = new int[6] { 3, 4, 5, 24, 25, 26 };
        int[] bytes = new int[6];
        for (int i = 0; i < 6; i++)
        {
            bytes[i] = ((enteredNumber & (mask << index[i])) >> index[i]) == 1 ? 1 : 0;

        }
        //doing the exchanges
        for (int i = 0; i < 3; i++)
        {
            if (bytes[i + 3] == 1) enteredNumber = enteredNumber | (mask << index[i]);
            else
            {
                int bit = ((enteredNumber & (mask << index[i])) >> index[i]) == 1 ? 1 : 0;
                if (bit == 1) enteredNumber = enteredNumber ^ (mask << index[i]);
                else enteredNumber = enteredNumber | 0;
            }
        }
        for (int i = 3; i < 6; i++)
        {
            if (bytes[i - 3] == 1) enteredNumber = enteredNumber | (mask << index[i]);
            else
            {
                int bit = ((enteredNumber & (mask << index[i])) >> index[i]) == 1 ? 1 : 0;
                if (bit == 1) enteredNumber = enteredNumber ^ (mask << index[i]);
                else enteredNumber = enteredNumber | 0;
            }
        }
        Console.WriteLine(enteredNumber);
    }
}
