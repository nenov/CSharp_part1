using System;
class PlayWithIntDoubleString
{
    static void Main()
    {
        //Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        //If the variable is int or double, the program increases it by one.
        //If the variable is a string, the program appends * at the end.
        //Print the result at the console. Use switch statement.
        Console.WriteLine("Please choose a type: \n1 --> int\n2 --> double\n3 --> string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Please enter an integer: "); int number; number = int.Parse(Console.ReadLine()); Console.WriteLine(number+1); break;
            case 2:
                Console.Write("Please enter an double: "); double number2; number2 = double.Parse(Console.ReadLine()); Console.WriteLine(number2 + 1); break;
            case 3:
                Console.Write("Please enter an string: "); string stuff; stuff = Console.ReadLine(); Console.WriteLine(stuff + "*"); break;
            default: Console.WriteLine("Incorrect input");
                break;
        }
    }
}