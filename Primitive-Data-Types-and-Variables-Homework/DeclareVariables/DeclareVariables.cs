using System;

class DeclareVariables
{
    static void Main()
    {

        /*the sbyte type represents signed 8-bit integers with values between –128 and 127.
        The byte type represents unsigned 8-bit integers with values between 0 and 255.
        The short type represents signed 16-bit integers with values between –32768 and 32767.
        The ushort type represents unsigned 16-bit integers with values between 0 and 65535.
        The int type represents signed 32-bit integers with values between –2147483648 and 2147483647.
        The uint type represents unsigned 32-bit integers with values between 0 and 4294967295.
        The long type represents signed 64-bit integers with values between –9223372036854775808 and 9223372036854775807.
        The ulong type represents unsigned 64-bit integers with values between 0 and 18446744073709551615.*/
        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        int thirdNumber = 4825932;
        byte forthNumber = 97;
        short fifthNumber = -10000;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        Console.WriteLine(thirdNumber);
        Console.WriteLine(forthNumber);
        Console.WriteLine(fifthNumber);

    }
}

