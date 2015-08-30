using System;
class BitsExchangeAdv
{
    static void Main()
    {
        //Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
        Console.WriteLine("Please enter a unsigned integer: ");

        try
        {
            uint enteredNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter p:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter q:");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k:");
            int k = int.Parse(Console.ReadLine());
            if (p < 0 || p > 31 || q < 0 || q > 31 || p + k - 1 > 31 || q + k - 1 > 31 || q + k - 1 < 0 || p + k - 1 < 0)
            {
                Console.WriteLine("out of range");
            }
            else
            {
                uint mask = 1;
                int[] index = new int[k * 2];
                //creating the indexes
                for (int i = 0; i < k; i++)
                {
                    index[i] = p + i;
                }
                for (int i = k; i < k * 2; i++)
                {
                    index[i] = q;
                    q++;
                }
                //checking for overlapping positions
                bool error = true;
                for (int i = 0; i < k * 2; i++)
                {
                    for (int v = 0; v < k * 2; v++)
                    {
                        if (i != v && error == true)
                        {
                            if (index[i] == index[v]) error = false;
                        }
                    }
                }
                if (error == false)
                {
                    Console.WriteLine("Overlapping");
                }
                else
                {
                    int[] bytes = new int[k * 2];
                    //checking the bits at the positions
                    for (int i = 0; i < k * 2; i++)
                    {
                        bytes[i] = ((enteredNumber & (mask << index[i])) >> index[i]) == 1 ? 1 : 0;

                    }
                    //doing the exchanges
                    for (int i = 0; i < k; i++)
                    {
                        if (bytes[i + k] == 1) enteredNumber = enteredNumber | (mask << index[i]);
                        else
                        {
                            int bit = ((enteredNumber & (mask << index[i])) >> index[i]) == 1 ? 1 : 0;
                            if (bit == 1) enteredNumber = enteredNumber ^ (mask << index[i]);
                            else enteredNumber = enteredNumber | 0;
                        }
                    }
                    for (int i = k; i < k * 2; i++)
                    {
                        if (bytes[i - k] == 1) enteredNumber = enteredNumber | (mask << index[i]);
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
        }
        catch (Exception)
        {
            Console.WriteLine("Out of Range");
        }
    }
}
