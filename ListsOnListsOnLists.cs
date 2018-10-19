using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_on_List_on_List
{
    class Program
    {

        /*
        Create a list of strings, and then create various methods that allows the user to add, search, and sort to the list of strings.

        1. Create a list – 5 points

        2. Give the ability to add items to the list– 5 points

        3. Give the ability for the user to search the list – 5 points

        4. Give the ability to sort in alphabetical order - 5 points

        5. Give the ability to print list to console – 5 points

        6. Put the add, search, and sort functions into their own methods - 5 points
        */


        static void Main(string[] args)
        {

            List<string> animals = new List<string>(5);


            Console.WriteLine("Let's fill a list up with animal names! They can be real or fake! ");

            while (true)
            {
                Console.WriteLine("Please enter an animal name:");

                animals.Add(Console.ReadLine().ToLower());

                Console.WriteLine("ADDED!");

                Console.WriteLine("Would you like to add another animal to the list?\n('y' for YES, anything else for NO!");

                char answer = Console.ReadKey(true).KeyChar;

                if (answer == 'y' || answer == 'Y')
                {
                    continue;
                }
                else
                {
                    break;
                }

            }



            while (true)
            {

                Console.Clear();

                Console.Write("Would you like to...\n1) search the list\n2) sort the list in alphabetical order\n3) print the list\n4) add an animal\n" +
                                   "5) exit\nPlease enter the number of your choice:");

                int choice = CheckNumber(true);

                if (choice == 5)
                {
                    break;
                }
                else if (choice == 4)
                {
                    animals.Add(NewAnimal());
                }
                else if (choice == 3)
                {
                    PrintList(animals);
                }
                else if (choice == 2)
                {
                    animals = SortList(animals);
                }
                else if (choice == 1)
                {
                    AnimalSearch(animals);
                }
                else
                {
                    continue;
                }




            }



            //-----------------------------------------------------------------------------------------------------------------------------------------
        }

        static void PrintList(List<string> animals)
        {
            Console.WriteLine("Here is the list...");
            foreach (string animal in animals)
            {
                Console.WriteLine("-" + animal);
            }
            Console.WriteLine("\n\ntype anything to exit list...");
            Console.ReadKey(true);
        }



        static List<string> SortList(List<string> animals)
        {
            animals.Sort();
            Console.WriteLine("The List was sorted!");

            Console.WriteLine("\n\ntype anything...");
            Console.ReadKey(true);

            return animals;
        }


        static void AnimalSearch(List<string> animals)
        {
            Console.WriteLine("Please enter the name of animal you would like to search for:");
            string search = Console.ReadLine();

            if (animals.Contains(search.ToLower()))
            {
                Console.WriteLine("Found animal: {0}\nFound at array index: {1}", search, animals.IndexOf(search.ToLower()));
            }
            else
            {
                Console.WriteLine("{0} was not found.", search);
            }

            Console.WriteLine("\n\npress anything to continue...");
            Console.ReadKey(true);
        }


        static string NewAnimal()
        {
            Console.WriteLine("Please enter the name for the new animal!");

            string newAnimal = Console.ReadLine();

            Console.WriteLine("{0} has been added!", newAnimal);

            Console.WriteLine("\n\npress anything to continue...");
            Console.ReadKey(true);

            return newAnimal;
            
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
