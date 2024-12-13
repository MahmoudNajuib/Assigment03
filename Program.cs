//     Mahmoud Najuib AbdEltwab     -    C42-G02-C#03    -    Have Exception in Deliver The Assignment.
//

namespace Assigment03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no:

            //Console.Write("Enter a Number: ");

            //if (int.TryParse(Console.ReadLine(), out int Number))         //Passing by "Out".
            //{
            //    if (Number % 3 == 0 && Number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input. Please Enter a Valid Number.");
            //}

            #endregion

            #region 2. Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive:

            //Console.Write("Enter an Integer: ");

            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    if (Number < 0)
            //    {
            //        Console.WriteLine("Negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Positive");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input. Please Enter a Valid Integer.");
            //}

            #endregion

            #region 3. Write a program that takes 3 integers from the user then prints the max Element and the min element:

            //Console.WriteLine("Enter 3 Integers:\n");

            //Console.Write("Write a First Number: ");
            //int.TryParse(Console.ReadLine(), out int Num1);

            //Console.Write("Write a Second Number: ");
            //int.TryParse(Console.ReadLine(), out int Num2);

            //Console.Write("Write a Third Number: ");
            //int.TryParse(Console.ReadLine(), out int Num3);

            //int Max = Math.Max(Num1, Math.Max(Num2, Num3));         //From Inside to Outside.
            //int Min = Math.Min(Num1, Math.Min(Num2, Num3));         //From Inside to Outside.

            //Console.WriteLine($"\nThe Max Element: {Max}");
            //Console.WriteLine($"The Min Element: {Min}");


            //Or:


            //st_Num:     //As a Reference.
            //Console.Write("Write a First Number: ");
            //if (int.TryParse(Console.ReadLine(), out int Num1))
            //{
            //    nd_Num:
            //    Console.Write("Write a Second Number: ");
            //    if (int.TryParse(Console.ReadLine(), out int Num2))
            //    {
            //        rd_Num:
            //        Console.Write("Write a Third Number: ");
            //        if (int.TryParse(Console.ReadLine(), out int Num3))
            //        {
            //            int Max = Math.Max(Num1, Math.Max(Num2, Num3));         //Froms Inside to Outside.
            //            int Min = Math.Min(Num1, Math.Min(Num2, Num3));         //Froms Outside to Inside.

            //            Console.WriteLine($"\nThe Max Element: {Max}");
            //            Console.WriteLine($"The Min Element: {Min}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Input. Please Enter a Valid Integer.\n");
            //            goto rd_Num;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Input. Please Enter a Valid Integer.\n");
            //        goto nd_Num;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input. Please Enter a Valid Integer.\n");
            //    goto st_Num;        //To go to The Reference.
            //}

            #endregion

            #region 4. Write a program that allows the user to insert an integer number then check If a number is even or odd:

            //Console.Write("Enter an integer: ");

            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("This Number is Even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This Number is Odd.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input. Please Enter a Valid Integer.");
            //}

            #endregion

            #region 5. Write a program that takes character from the user, then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant):

            ////try           //No Need To Use Try / Catch:
            ////{

            //Console.Write("Enter A Character: ");

            //char input = Console.ReadKey().KeyChar;     //Char: For Single Entry Character.

            //Console.WriteLine();
            //char Entry = char.ToLower(input);          //To Convert The Character to lowercase.

            //if (Entry == 'a' || Entry == 'e' || Entry == 'i' || Entry == 'o' || Entry == 'u')
            //{
            //    Console.WriteLine($"The Character '{input}' is Vowel");
            //}
            //else if (char.IsLetter(Entry))
            //{
            //    Console.WriteLine($"The Character '{input}' is Consonant");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input. Please Enter a Valid letter.\n");
            //}

            ////}
            ////catch 
            ////{
            ////    Console.WriteLine("Invalid Input. Please Enter a letter.");
            ////}

            #endregion

            #region 6. Write a program that allows the user to insert an integer then print all numbers between 1 to that number:

            //Console.Write("Enter an Integer: ");

            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    if (Number >= 1)
            //    {
            //        Console.Write($"\nNumbers from 1 to {Number}:      ");
            //        for (int i = 1; i <= Number; i++)
            //        {
            //            if (i < Number)                     //To Add ',' Between Numbers.
            //            {
            //                Console.Write($"{i}, ");
            //            }
            //            else                                //To Stop Adding ',' Between Numbers After Last Number.
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please Enter a Number is Equal or Above '1'.");          //To Refuse '0' and Negative Numbers Without Errors.
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please Enter a Valid Integer.");              //To Refuse Any Else Characters Without Errors.
            //}

            #endregion

            #region 7. Write a program that allows the user to insert an integer then print a multiplication table up to 12:

            //Console.Write("Enter an Integer: ");

            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    Console.WriteLine($"\nThe Multiplicatio table for {Number}:\n");

            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{Number} x {i} = {Number * i}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input. Please Enter a Valid Integer.");
            //}

            #endregion

            #region 8. Write a program that allows to user to insert number then print all even numbers between 1 to this number:

            //Console.Write("Enter a Number: ");

            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    Console.Write($"\nEven numbers between 1 and {Number}:    ");

            //    for (int i = 2; i <= Number; i += 2)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input. Please Enter a Valid Integer.");
            //}

            #endregion

            #region 9. Write a program that takes two integers then prints the power:

            //Console.Write("Enter The Base Number: ");
            //if (int.TryParse(Console.ReadLine(), out int BaseNumber))
            //{
            //    Console.Write("Enter The Exponent Number: ");
            //    if (int.TryParse(Console.ReadLine(), out int Exponent))
            //    {
            //        double Result = Math.Pow(BaseNumber, Exponent);         //Power Function 
            //        Console.WriteLine("\n" + Result);
            //        ////Or:
            //        //Console.WriteLine($"The Power of {Exponent} for {BaseNumber} is: {Result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Exponent Input. Please Enter a Valid Integer.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Base Input. Please Enter a Valid Integer.");
            //}

            #endregion

            #region 10. Write a program to enter marks of five subjects and calculate total, average and percentage: **************

            //    Console.WriteLine("Enter Marks for Five Subjects:\n");
            //    Double Sub1, Sub2, Sub3, Sub4, Sub5;
            //One:
            //    Console.Write($"Enter Marks for Subject '1': ");
            //    if (Double.TryParse(Console.ReadLine(), out Sub1) && Sub1 >= 0 && Sub1 <= 100)
            //    {
            //    Two:
            //        Console.Write($"Enter Marks for Subject '2': ");
            //        if (Double.TryParse(Console.ReadLine(), out Sub2) && Sub2 >= 0 && Sub2 <= 100)
            //        {
            //        Three:
            //            Console.Write($"Enter Marks for Subject '3': ");
            //            if (Double.TryParse(Console.ReadLine(), out Sub3) && Sub3 >= 0 && Sub3 <= 100)
            //            {
            //            Four:
            //                Console.Write($"Enter Marks for Subject '4': ");
            //                if (Double.TryParse(Console.ReadLine(), out Sub4) && Sub4 >= 0 && Sub4 <= 100)
            //                {
            //                Five:
            //                    Console.Write($"Enter Marks for Subject '5': ");
            //                    if (Double.TryParse(Console.ReadLine(), out Sub5) && Sub5 >= 0 && Sub5 <= 100)
            //                    {

            //                        //Decimal Total = Sub1 + Sub2 + Sub3 + Sub4 + Sub5;
            //                        Double Total = Sub1 + Sub2 + Sub3 + Sub4 + Sub5;

            //                        //Displaying Results:
            //                        Console.WriteLine("\n\nResults:\n");

            //                        //Total:
            //                        Console.WriteLine($"Total marks = {Total}");

            //                        //Average:
            //                        Console.WriteLine($"Average Marks = {Total / 5}");

            //                        //Percentage:
            //                        Console.WriteLine($"Percentage = {Total * 100 / 500}%");

            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Invalid Input. Please Enter a Valid Integer Again.\n");
            //                        goto Five;        //To go to The Reference.
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid Input. Please Enter a Valid Integer Again.\n");
            //                    goto Four;        //To go to The Reference.
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid Input. Please Enter a Valid Integer Again.\n");
            //                goto Three;        //To go to The Reference.
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Input. Please Enter a Valid Integer Again.\n");
            //            goto Two;        //To go to The Reference.
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Input. Please Enter a Valid Integer Again.\n");
            //        goto One;        //To go to The Reference.
            //    }

            #endregion

            #region 11. Write a program to input the month number and print the number of days in that month:

            /* Days of Months:
            Month 1  = 31
            Month 2  = 28
            Month 3  = 31
            Month 4  = 30
            Month 5  = 31
            Month 6  = 30
            Month 7  = 31
            Month 8  = 31
            Month 9  = 30
            Month 10 = 31
            Month 11 = 30
            Month 12 = 31
            */

            //Top:
            //    Console.Write("Month Number: ");

            //    if (int.TryParse(Console.ReadLine(), out int Month))
            //    {
            //        int MonthDays = 0;

            //        if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            //        {
            //            MonthDays = 30;
            //        }
            //        else if (Month == 2)
            //        {
            //            MonthDays = 28;
            //        }
            //        else if (Month >= 1 && Month <= 12)
            //        {
            //            MonthDays = 31;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nInvalid Month Number. Please Enter a Valid Month Number\n\n");
            //            goto Top;
            //        }

            //        Console.WriteLine($"\nDays in Month '{Month}' is: {MonthDays}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nInvalid Input. Please Enter a Valid Month Number.\n\n");
            //        goto Top;
            //    }

            #endregion

            #region 12. Write a program to create a Simple Calculator:

            //    Console.Title = "Simple Calculator";

            //Adding_Numbers:
            //    Console.Write("Enter The First Number: ");
            //    double Num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter The Second Number: ");
            //    double Num2 = Convert.ToDouble(Console.ReadLine());

            ////Operations:
            //Operations:
            //    Console.WriteLine("Select an Operation:\n");
            //    Console.WriteLine("1. Addition (+)");
            //    Console.WriteLine("2. Subtraction (-)");
            //    Console.WriteLine("3. Multiplication (*)");
            //    Console.WriteLine("4. Division (/)");
            //    Console.Write("Enter an Operation (1/2/3/4): ");

            //    int Operation = Convert.ToInt32(Console.ReadLine());
            //    double Result = 0;

            //    switch (Operation)
            //    {
            //        case 1:
            //            Result = Num1 + Num2;
            //            Console.WriteLine($"\nResult: {Num1} + {Num2} = {Result}");
            //            break;
            //        case 2:
            //            Result = Num1 - Num2;
            //            Console.WriteLine($"\nResult: {Num1} - {Num2} = {Result}");
            //            break;
            //        case 3:
            //            Result = Num1 * Num2;
            //            Console.WriteLine($"\nResult: {Num1} * {Num2} = {Result}");
            //            break;
            //        case 4:
            //            if (Num2 != 0)          //cause It isn't Possible to Division by Zero.
            //            {
            //                Result = Num1 / Num2;
            //                Console.WriteLine($"\nResult: {Num1} / {Num2} = {Result}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("\nError: Division by '0' is not Allowed. Please Try Again:\n\n");
            //                goto Adding_Numbers;
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("\nInvalid Operation Selected.");
            //            goto Operations;
            //    }

            #endregion
        }
    }
}
