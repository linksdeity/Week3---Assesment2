using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_One_Ou
{
    class Program
    {
        /*
         #2 - Odd One Out – 20 Points

        Use a for loop to calculate the sum of all odd numbers between 1 and a number (n) entered by the user. 
        The program should also print the sum and the average on the console.

        1. Accept and validate user input to determine the range – 5 points

        2. Program correctly calculates the sum of the odd numbers within the range and prints answer to console – 5 points

        3. Program correctly calculates the average of the odd numbers within the range and prints answer to console – 5 points

        4. Create methods for calculating sum and average - 5 points

        */


        static void Main(string[] args)
        {
  


            Console.WriteLine("Please enter a non-zero positive number, this will be the highest number we use:");

            int number = CheckNumber(true);


            int[] numArray = new int[number];



            for (int i = 0; i < number; i++)
            {
                numArray[i] = i + 1;
            }

            double averageNum = Average(numArray);

            int sumNum = Sum(numArray);

            Console.WriteLine("The odd numbers in the array are:");


            foreach (int newnumber in numArray)
            {
                if (newnumber % 2 > 0)
                {

                    Console.Write(newnumber + ", ");

                }

            }


            Console.WriteLine("\n\nThe average is {0}, the total is {1}", averageNum, sumNum);

            Console.ReadKey();


        }




        static double Average(int[] numArray)
        {

            double counter = 0.0;
            double adder = 0.0;

            foreach(int number in numArray)
            {
                if(number % 2 > 0)
                {
                    counter++;

                    adder += number;

                }

            }

            return (adder / counter);

        }



        static int Sum(int[] numArray)
        {

            int adder = 0;

            foreach (int number in numArray)
            {
                if (number % 2 > 0)
                {


                    adder += number;

                }

            }

            return adder;



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
