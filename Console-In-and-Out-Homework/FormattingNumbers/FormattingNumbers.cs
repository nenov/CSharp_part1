using System;
using System.Globalization;
class FormattingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer number which is between 0 and 500:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a floating-point number:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second floating-point number:");
            float c = float.Parse(Console.ReadLine());
            //{ index[,alignment][:formatString]}
            Console.WriteLine("{0,-10:X}|{1:10}|{2,10}|{3,-10}|", a, Convert.ToString(a, 2).PadLeft(10, '0'),
                b.ToString("F",CultureInfo.InvariantCulture), c.ToString("F3",CultureInfo.InvariantCulture));
        }
    }