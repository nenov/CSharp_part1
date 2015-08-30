using System;
class ModifyBitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer: ");
        int enteredNumber = int.Parse(Console.ReadLine());
        int mask = 1;
        Console.WriteLine("Please enter the position of the bit: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the value to be put: ");
        int value = int.Parse(Console.ReadLine());
        mask = mask << index;
        int result;
        if (value == 1) result = enteredNumber | mask;
        else
        {
            int bit = ((enteredNumber & mask) >> index) == 1 ? 1 : 0;
            if (bit == 1) result = enteredNumber ^ mask;
            else result = enteredNumber | 0;
        }
        Console.WriteLine(result);
    }
}