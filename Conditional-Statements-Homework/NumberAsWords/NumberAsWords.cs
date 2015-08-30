using System;
class NumberAsWords
{
    static void Main()
    {
        //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
        Console.WriteLine("Please enter a number in the range [9...999]: ");
        int num = int.Parse(Console.ReadLine());
        string hundreds = "";
        string tens = "";
        string digit = "";
        if (num == 0) Console.WriteLine("Zero");
        else
        {
            switch (num / 100)
            {
                case 1: hundreds = ("One hundred"); break;
                case 2: hundreds = ("Two hundred"); break;
                case 3: hundreds = ("Three hundred"); break;
                case 4: hundreds = ("Four hundred"); break;
                case 5: hundreds = ("Five hundred"); break;
                case 6: hundreds = ("Six hundred"); break;
                case 7: hundreds = ("Seven hundred"); break;
                case 8: hundreds = ("Eight hundred"); break;
                case 9: hundreds = ("Nine hundred"); break;
                default:
                    break;
            }
            num = num % 100;
            if (num >= 10 && num < 20) switch (num % 10)
                {
                    case 0: tens = ("ten"); break;
                    case 1: tens = ("eleven"); break;
                    case 2: tens = ("twelve"); break;
                    case 3: tens = ("thirteen"); break;
                    case 4: tens = ("fourteen"); break;
                    case 5: tens = ("fifteen"); break;
                    case 6: tens = ("sixteen"); break;
                    case 7: tens = ("seventeen"); break;
                    case 8: tens = ("eighteen"); break;
                    case 9: tens = ("nineteen"); break;
                    default:
                        break;
                }
            else if (num >= 20)
            {
                switch (num / 10)
                {
                    case 2: tens = ("twenty "); break;
                    case 3: tens = ("thirty "); break;
                    case 4: tens = ("fourty "); break;
                    case 5: tens = ("fifty "); break;
                    case 6: tens = ("sixty "); break;
                    case 7: tens = ("seventy "); break;
                    case 8: tens = ("eighty "); break;
                    case 9: tens = ("ninety "); break;
                    default:
                        break;
                }
            }
            if (num < 10 || num > 19)
                switch (num % 10)
                {
                    case 1: digit = ("one"); break;
                    case 2: digit = ("two"); break;
                    case 3: digit = ("three"); break;
                    case 4: digit = ("four"); break;
                    case 5: digit = ("five"); break;
                    case 6: digit = ("six"); break;
                    case 7: digit = ("seven"); break;
                    case 8: digit = ("eight"); break;
                    case 9: digit = ("nine"); break;
                    default:
                        break;
                }
            //building the final result
            if (hundreds != "" & tens == "" && digit == "") Console.WriteLine(hundreds);
            else
            {
                if (hundreds != "" && (tens != "" || digit != "")) hundreds = hundreds + " and ";
                else if (tens != "") tens = tens.Substring(0, 1).ToUpper() + tens.Substring(1);
                else digit = digit.Substring(0, 1).ToUpper() + digit.Substring(1);
                Console.WriteLine(hundreds + tens + digit);
            }
        }
    }
}