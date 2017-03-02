using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prep_Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------------------------------------
            //Question #1

            //double num;
            //double sum = 0;
            //double avg = 0;
            //int i;

            //for(i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please enter a number");
            //    num = double.Parse(Console.ReadLine());
            //    Console.WriteLine(num);
            //    sum = sum + num;
            //}
            //avg = sum / 3;
            //Console.WriteLine("The avg is: {0}", avg);

            //---------------------------------------------------------------------------------------------------------
            //Question #2

            //int num;

            //Console.WriteLine("Please enter a number");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine("num^2 = {0}", num * num);

            //---------------------------------------------------------------------------------------------------------
            //Question #3

            //double[] myDoubleArray = new double[4];
            //double calc;
            //int i;

            //for(i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Please enter a number");
            //    myDoubleArray[i] = double.Parse(Console.ReadLine());
            //}
            //calc = myDoubleArray[0] + myDoubleArray[1];
            //Console.WriteLine("{0} + {1} = {2}", myDoubleArray[0], myDoubleArray[1], calc);
            //calc = myDoubleArray[3] - myDoubleArray[1];
            //Console.WriteLine("{0} - {1} = {2}", myDoubleArray[3], myDoubleArray[1], calc);
            //calc = myDoubleArray[2] / 8;
            //Console.WriteLine("{0} / 8 = {1}", myDoubleArray[2], calc);
            //calc = myDoubleArray[3] * myDoubleArray[0];
            //Console.WriteLine("{0} * {1} = {2}", myDoubleArray[3], myDoubleArray[0], calc);

            //---------------------------------------------------------------------------------------------------------
            //Question #4

            //int num1;
            //int num2;

            //Console.WriteLine("Please enter two numbers");
            //num1 = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Before swap - Number 1 is: {0}; Number 2 is: {1}", num1, num2);

            //num1 = num1 + num2;
            //num2 = num1 - num2;
            //num1 = num1 - num2;

            //Console.WriteLine("After swap - Number 1 is: {0}; Number 2 is: {1}", num1, num2);

            //---------------------------------------------------------------------------------------------------------
            //Question #5

            //int movieLength;

            //Console.WriteLine("Please enter the movie length in minutes");
            //movieLength = int.Parse(Console.ReadLine());

            //Console.WriteLine("The movie length is: {0} hours(s) and {1} minutes", (movieLength / 60), (movieLength % 60));

            //---------------------------------------------------------------------------------------------------------
            //Question #6

            //string numFourDig;

            //Console.WriteLine("Please enter a four digits number");
            //numFourDig = Console.ReadLine();

            //Console.WriteLine("Thousands digit is: {0}, Hundreds digit is: {1}, Tens digit is: {2}, Units digit is: {3}", 
            //    numFourDig[0], numFourDig[1], numFourDig[2], numFourDig[3]);

            //---------------------------------------------------------------------------------------------------------
            //Question #7

            //int numTwoDig;

            //Console.WriteLine("Please enter a two digits number");
            //numTwoDig = int.Parse(Console.ReadLine());

            //Console.WriteLine("SUM of two digits is: {0}", ((numTwoDig / 10) + (numTwoDig % 10)));

            //---------------------------------------------------------------------------------------------------------
            //Question #8

            //int num10To99;
            //int reverseNum10To99 = 0;

            //Console.WriteLine("Please enter a number between 10 to 99");
            //num10To99 = int.Parse(Console.ReadLine());

            //if ((num10To99 >= 10) && (num10To99 <= 99))
            //{
            //    Console.WriteLine("Before - {0}", num10To99);

            //    while (num10To99 > 0)
            //    {
            //        reverseNum10To99 = (reverseNum10To99 * 10) + (num10To99 % 10);
            //        num10To99 = num10To99 / 10;
            //    }
            //    Console.WriteLine("After - {0}", reverseNum10To99);
            //}
            //else
            //    Console.WriteLine("The number you entered is out of range");

            //---------------------------------------------------------------------------------------------------------
            //Question #9

            //double num;

            //Console.WriteLine("Please enter a REAL number");
            //num = double.Parse(Console.ReadLine());

            //string[] str = num.ToString().Split('.'); /*Create new string array with two elements:
            //Index '0' - Before decimal point; Index '1' - After decimal point*/

            //if (str.Count() > 1) //Check if Index '1' is exist = there are numbers after the decimal point = the number entered is REAL
            //{
            //    Console.WriteLine("Numbers after decimal point are: {0}", str[1]);
            //}
            //else
            //{
            //    Console.WriteLine("The number you entered is not a REAL number");
            //}

            //---------------------------------------------------------------------------------------------------------
            //Question #10

            //int num1;
            //int num2;

            //Console.WriteLine("Please enter the first number");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number");
            //num2 = int.Parse(Console.ReadLine());

            //if(num1 > num2)
            //{
            //    Console.WriteLine("The min number is: {0} and the max number is: {1}", num2, num1);
            //}
            //else
            //{
            //    Console.WriteLine("The min number is: {0} and the max number is: {1}", num1, num2);
            //}

            //---------------------------------------------------------------------------------------------------------
            //Question #11

            //int[] myArray = new int[3];
            //int i;

            //for(i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("Please enter a number");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(myArray);
            //foreach (int value in myArray)
            //{
            //    Console.Write("{0} ", value);
            //}
            //Console.WriteLine();

            //---------------------------------------------------------------------------------------------------------
            //Question #12

            //string name;
            //int age;
            //int height;

            //Console.WriteLine("Please enter the player name");
            //name = Console.ReadLine();
            //Console.WriteLine("Please enter the player age");
            //age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the player height");
            //height = int.Parse(Console.ReadLine());

            //if (height > 182)
            //{
            //    if (((age >= 14) && (age <= 18)) || ((age >= 21) && (age <= 26)))
            //    {
            //        Console.WriteLine("The player \"{0}\" passed the admissions criteria of Maccabi Tel Aviv", name);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The player \"{0}\" did not pass the admissions criteria of Maccabi Tel Aviv", name);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The player \"{0}\" did not pass the admissions criteria of Maccabi Tel Aviv", name);
            //}

            //---------------------------------------------------------------------------------------------------------
            //Question #13

            //int numOfAsterisks;
            //int i;
            //int j;

            //Console.WriteLine("Please enter a number");
            //numOfAsterisks = int.Parse(Console.ReadLine());

            //for (i = 0; i < numOfAsterisks; i++)
            //{
            //    for (j = 0; j < numOfAsterisks; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //---------------------------------------------------------------------------------------------------------
            //Question #14

            //int i;
            //int j;

            //Console.WriteLine("This is a Multiplication Table\n");

            //for(i = 1; i <= 10; i++)
            //{
            //    for(j = 1; j <= 10; j++)
            //    {
            //        Console.Write("{0}\t", (i * j));
            //    }
            //    Console.WriteLine("\n");
            //}

            //---------------------------------------------------------------------------------------------------------
            //Questions #15 & 16

            //int selection;
            //int number;
            //int max;
            //int min;

            //Console.WriteLine("Please select an option\n");
            //Console.WriteLine("1) Print the min number"); //Question #15
            //Console.WriteLine("2) Print the max number\n"); //Question #16

            //selection = int.Parse(Console.ReadLine());

            //switch(selection)
            //{
            //    case 1:
            //        Console.WriteLine("Please enter a number");
            //        min = int.Parse(Console.ReadLine());
            //        if (min > 0)
            //        {
            //            do
            //            {
            //                Console.WriteLine("Please enter a number");
            //                number = int.Parse(Console.ReadLine());
            //                if ((number < min) && (number > 0))
            //                {
            //                    min = number;
            //                }
            //            } while (number > 0);
            //            Console.WriteLine("The min number is: {0}", min);
            //        }
            //        break;
            //    case 2:
            //        Console.WriteLine("Please enter a number");
            //        max = int.Parse(Console.ReadLine());
            //        if (max > 0)
            //        {
            //            do
            //            {
            //                Console.WriteLine("Please enter a number");
            //                number = int.Parse(Console.ReadLine());
            //                if (number > max)
            //                {
            //                    max = number;
            //                }
            //            } while (number > 0);
            //            Console.WriteLine("The max number is: {0}", max);
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("The option you selected is not allowed");
            //        break;
            //}

            //---------------------------------------------------------------------------------------------------------

        }
    }
}
