using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheMax
{
    class Program
    {
        /*
        #1 - To The Max! – 15 Points

            Write a program that will take input from the user, find the maximum number inside an array, 
            using a foreach loop, and then print that number on the console.
        
        1. Create an array that will hold a number (n) of numbers – 5 points
        
        2. Ask and validate numbers from user to fill the array. - 5 points
        
        3. Correctly write a foreach loop to loop through the array and print correct answer to console – 5 points
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a non-negative number for the length of the array:");

            int length = CheckNumber(true);

            int[] numArray = new int[length];


            Console.WriteLine("Now please enter {0} numbers:", length);

            for (int i = 0; i < length; i++)
            {
                numArray[i] = CheckNumber(false);
            }


            Console.WriteLine("\n\nHere are the numbers you entered:");

            foreach(int number in numArray)
            {
                Console.Write(number + ", ");
            }

            int saver = numArray[0];


            foreach(int number in numArray)
            {
                if (number > saver)
                {
                    saver = number;
                }
            }

            Console.WriteLine("\n\nThe largest number you enterd is:{0}", saver);

            Console.ReadKey();


        }


        static int CheckNumber(bool negatives)
        {
            while (true)
            {
                int number;

                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please type in a number!");
                    continue;
                }

                if (negatives == true)
                {
                    if (number <= 0)
                    {
                        Console.WriteLine("Please keep the number positive!");
                        continue;
                    }
                }

                return number;

            }

        }




    }
}
