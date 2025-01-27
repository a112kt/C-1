using System.Reflection.Metadata;

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.
            //Console.Write("Please Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"The number you Entre is {num}");


            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //Console.Write("Enter a String : ");
            //string Str  = Console.ReadLine() ??" ";
            //int.TryParse(Str, out int result);
            //Console.WriteLine($"The string after Convert to number is {result}");
            //if the string contains non-numeric print 0


            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //Console.Write("Enter Frist Num : ");
            //Double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter Second Num : ");
            //Double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.Clear();

            //Double Sum = num1 + num2;
            //Double Sub = num1 - num2;
            //Double Mul = num1 * num2;
            //Double Div = num1 / num2;

            //Console.WriteLine($"The sum of two number is {Sum}");
            //Console.WriteLine($"The Sub of two number is {Sub}");
            //Console.WriteLine($"The Mul of two number is {Mul}");
            //Console.WriteLine($"The Div of two number is {Div}");


            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.
            //Console.Write("Please Enter a word : ");
            //string word = Console.ReadLine();
            //string subWord = word.Substring(1,4);
            //Console.WriteLine($"The subString is {subWord}");


            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int num1 = 4;
            //int num2 = 7;
            //num1 = num2;
            //Console.WriteLine($"Number1 is {num1}, Number2 is {num2}");
            //num2 = 20;
            //Console.WriteLine($"Number1 is {num1}, Number2 is {num2}");



            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = arr1;
            Console.WriteLine($"Array1 is {arr1[0]} , Array2 is {arr2[0]}");
            arr1[0] = 200;
            Console.WriteLine($"Array1 is {arr1[0]} , Array2 is {arr2[0]}");
            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 

            //Console.Write("Enter a frist Word : ");
            //string word1 = Console.ReadLine();

            //Console.Write("Enter a second Word : ");
            //string word2 = Console.ReadLine();
            //Console.Clear();

            //string result = string.Concat(word1," ", word2);
            //Console.WriteLine($"The word is {result}");


            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.

            //Console.Write("Enter a principal : ");
            //Double principal = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter a rate of interest : ");
            //Double rate = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter a  time : ");
            //Double time = Convert.ToDouble(Console.ReadLine());

            //Double interest = (principal * rate * time) / 100;

            //Console.WriteLine($"simple interest is {interest}");




            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            //Console.Write("Enter person's weight in kilograms : ");
            //Double weight = Convert.ToDouble((Console.ReadLine()));

            //Console.Write("Enter person's height in meters : ");
            //Double height = Convert.ToDouble((Console.ReadLine()));
            //Console.Clear();

            //double BMI  = weight / (height * height);
            //Console.WriteLine($"The formula for BMI is {BMI}");



            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"


            //Console.Write("Enter a temperature  : ");
            //int tem = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //string result = (tem < 10) ? "Just Cold" : (tem > 30) ? "Just Hot" : "Just Good";
            //Console.WriteLine(result);



            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001

            //Console.Write("Enter a Day number : ");
            //int Day= Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a Month number : ");
            //int Month = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a year number : ");
            //int Year = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine($"Today’s date : {Day} , {Month} , {Year}");
            //Console.WriteLine($"Today’s date : {Day} / {Month} / {Year}");
            //Console.WriteLine($"Today’s date : {Day} - {Month} -{Year}");



            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No


            //Console.Write("Enter a number : ");
            //int num =Convert.ToInt32( Console.ReadLine());
            //if(num % 3 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive


            //Console.Write("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}



            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3


            //Console.Write("Enter a frist number : ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a second number : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a thrid number : ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //if (num1> num2 && num1 > num3 && num2 > num3)
            //{
            //    Console.WriteLine($"Max is {num1}");
            //    Console.WriteLine($"Min is {num3}");
            //}
            //else if (num1 > num2 && num1 > num3 && num3 > num2)
            //{
            //    Console.WriteLine($"Max is {num1}");
            //    Console.WriteLine($"Min is {num2}");
            //}
            //else if (num2 > num1 && num2 > num3 && num1 > num3){
            //    Console.WriteLine($"Max is {num2}");
            //    Console.WriteLine($"Min is {num3}");
            //}
            //else if (num2 > num1 && num2 > num3 && num3 > num1)
            //{
            //    Console.WriteLine($"Max is {num2}");
            //    Console.WriteLine($"Min is {num1}");
            //}
            //else if (num3 > num1 && num3 > num2 && num1 > num2)
            //{
            //    Console.WriteLine($"Max is {num3}");
            //    Console.WriteLine($"Min is {num2}");
            //}
            //else if (num3 > num1 && num3 > num2 && num2 > num1)
            //{
            //    Console.WriteLine($"Max is {num3}");
            //    Console.WriteLine($"Min is {num1}");
            //}
            //else
            //{
            //    Console.WriteLine("numbers Equal");
            //}






            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Even number");
            //}
            //else
            //{
            //    Console.WriteLine("Odd number");
            //}

            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant

            //Console.Write("Enter a Char : ");
            //char char1 =Convert.ToChar(Console.ReadLine());

            //switch (char1)
            //{
            //    case 'a':
            //        Console.WriteLine(" vowel chars ");
            //        break;
            //    case 'e':
            //        Console.WriteLine(" vowel chars ");
            //        break;
            //    case 'o':
            //        Console.WriteLine(" vowel chars ");
            //        break;
            //    case 'u':
            //        Console.WriteLine(" vowel chars ");
            //        break;
            //    case 'i':
            //        Console.WriteLine(" vowel chars ");
            //        break;
            //    default:
            //        Console.WriteLine("Not vowel chars");
            //        break;
            //}



            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31
            //Console.Write("Enter a month number : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 3:
            //        Console.WriteLine(" Days in Month: 31");
            //        break;
            //    case 5:
            //        Console.WriteLine("Days in Month: 31 ");
            //        break;
            //    case 7:
            //        Console.WriteLine(" Days in Month: 31 ");
            //        break;
            //    case 9:
            //        Console.WriteLine(" Days in Month: 31 ");
            //        break;
            //    case 10:
            //        Console.WriteLine(" Days in Month: 31 ");
            //        break;
            //    case 12:
            //        Console.WriteLine(" Days in Month: 31 ");
            //        break;
            //    case 2:
            //        Console.WriteLine(" Days in Month: 28 ");
            //        break;

            //    default:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //}





            #endregion

        }
    }
}
