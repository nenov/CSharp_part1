using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool flag = true;

        if (number < 2) flag = false;
        else if (number == 2 || number == 3) flag = true;
        else if (number % 2 == 0 || number % 3 == 0) flag = false;
        else
        {
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0) flag = false;
            }
        }
        Console.WriteLine(flag);
    }
}
