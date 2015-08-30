using System;
class ExtractBitFromInteger
    {
        static void Main()
        {
            //Write an expression that extracts from given integer n the value of given bit at index p.
            Console.WriteLine("Please enter an integer: ");
            int enteredNumber = int.Parse(Console.ReadLine());
            int mask = 1;
            Console.WriteLine("Please enter the position of the bit: ");
            int index = int.Parse(Console.ReadLine());
            mask = mask << index;
            int result = ((enteredNumber & mask) >> index) == 1 ? 1 : 0;
            Console.WriteLine(result);
        }
    }