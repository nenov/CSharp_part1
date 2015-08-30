using System;
using System.Text;
class PrintASCIITable
{
    static void Main()
    {
        //Console.OutputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("-----------------------------------------------------------------");
        for (int counter = 0; counter < 255; counter+=8)
        {
            if (counter < 96) Console.WriteLine("|" + counter + "  ->{0}|" + (counter + 1) + "  ->{1}|" + (counter + 2) + "  ->{2}|" + (counter + 3) + "  ->{3}|" + (counter + 4) + "  ->{4}|" + (counter + 5) + "  ->{5}|" + (counter + 6) + "  ->{6}|" + (counter + 7) + "  ->{7}|", (char)counter, (char)(counter + 1), (char)(counter + 2), (char)(counter + 3), (char)(counter + 4), (char)(counter + 5), (char)(counter + 6), (char)(counter + 7));
            else if (counter == 96)Console.WriteLine("|" + counter + "  ->{0}|" + (counter+1) + "  ->{1}|" + (counter+2) + "  ->{2}|" + (counter+3) + "  ->{3}|" + (counter+4) + " ->{4}|" + (counter+5) + " ->{5}|" + (counter+6) + " ->{6}|" + (counter+7) + " ->{7}|", (char)counter, (char)(counter + 1), (char)(counter + 2), (char)(counter + 3), (char)(counter + 4), (char)(counter + 5), (char)(counter + 6), (char)(counter + 7));

            else Console.WriteLine("|" + counter + " ->{0}|" + (counter+1) + " ->{1}|" + (counter+2) + " ->{2}|" + (counter+3) + " ->{3}|" + (counter+4) + " ->{4}|" + (counter+5) + " ->{5}|" + (counter+6) + " ->{6}|" + (counter+7) + " ->{7}|", (char)counter, (char)(counter + 1), (char)(counter + 2), (char)(counter + 3), (char)(counter + 4), (char)(counter + 5), (char)(counter + 6), (char)(counter + 7));

        }
        Console.WriteLine("-----------------------------------------------------------------");

    }
}
