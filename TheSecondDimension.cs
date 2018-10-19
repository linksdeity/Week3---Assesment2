using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Second_Dimension
{
    class Program
    {
        /*
        #4 - The Second Dimension – 35 points

        Write a method that will give us the sum of the diagonal of a 2D array:

        Example:

        public static int SumDiagonal(int[,] Matrix, int Dim) { }

        1. Create a 2D Int Array – 10 points

        2. Use nested loops to iterate through the array to get the index of each number in the diagonal position – 15 points

        3. Sum the numbers in the diagonal and print that number to console – 5 points

        4. Create a method that loops through the array and calculates the sum - 5 points
        */


        static void Main(string[] args)
        {

            int[][] newArray = new int[4][]
            {

                new int[4] {5, -4, 3, 0},
                new int[4] {5, 1, -2, -1},
                new int[4] {8, 6, -7, 4},
                new int[4] {-2, 1, -5, 2}
            };

            Console.WriteLine("The array is:");

            foreach(int[] numArray in newArray)
            {
                Console.Write("\n");

                foreach(int number in numArray)
                {
                    Console.Write("  {0,3}  ", number);
                }
            }


            Console.WriteLine("\n\nThe sum of the diagonal from top left to bottom right is: {0}", GetDiagonal(newArray));

            Console.WriteLine("\n\nThe sum of the diagonal from top right to bottom left is: {0}", GetReverseDiagonal(newArray));

            Console.WriteLine("\n\nThe sum of the entire array is: {0}", GetSum(newArray));

            Console.ReadKey();
        }



        static int GetDiagonal(int[][] newArray)
        {

            int sum = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                sum += newArray[i][i];
            }

            return sum;

        }

        static int GetReverseDiagonal(int[][] newArray)
        {
            int counter = 0;
            int sum = 0;

            for (int i = newArray.Length - 1; i >= 0; i--)
            {
                sum += newArray[counter][i];
                counter++;
            }

            return sum;

        }

        static int GetSum(int[][] newArray)
        {
            int total = 0;

            foreach(int[] numbers in newArray)
            {
                foreach(int number in numbers)
                {
                    total += number;
                }
            }

            return total;
        }






    }
}
