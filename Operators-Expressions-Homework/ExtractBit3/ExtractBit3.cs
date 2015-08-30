using System;
class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Please enter an unsigned integer: ");
        uint enteredNumber = uint.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << 3;
        int result = ((enteredNumber & mask) >> 3) == 1 ? 1 : 0;
        Console.WriteLine(result);
    }
}
