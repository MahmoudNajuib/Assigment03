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

            //int Max = Math.Max(Num1, Math.Max(Num2, Num3));         //Froms Inside to Outside.
            //int Min = Math.Min(Num1, Math.Min(Num2, Num3));         //Froms Outside to Inside.

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
            //        Console.Write($"Numbers from 1 to {Number}:      ");
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
            //    Console.WriteLine("Invalid input. Please Enter a Valid integer.");              //To Refuse Any Else Characters Without Errors.
            //}

            #endregion

            #region 7. 



            #endregion

            #region 8. 


            #endregion

            #region 9. 


            #endregion

            #region 10. 


            #endregion

            #region 11. 


            #endregion

            #region 12. 


            #endregion
        }
    }
}
