using System;
using System.Collections.Generic;

namespace part7keep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brandon Fraser
            Random generator = new Random();
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 25; i++)
            {
                int ranNum = generator.Next(10, 21);
                numbers.Add(ranNum);
            }

            string choice = "";
            while (choice != "q")
            {
                Console.WriteLine("Here is the list of numbers:");
                for (int i = 0; i < numbers.Count; i++)
                    Console.Write(numbers[i] + ", ");
                Console.WriteLine();
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Sort the list.");
                Console.WriteLine("2 - Make a new list.");
                Console.WriteLine("3 - Remove a number.");
                Console.WriteLine("4 - Add a number.");
                Console.WriteLine("5 - Count the number of occurrences of a specified number.");
                Console.WriteLine("6 - Print the largest value.");
                Console.WriteLine("7 - Print the smallest value.");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "q")
                {
                    Console.WriteLine("Goodbye.");
                }
                else if (choice == "1")
                {
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Sort();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                    for (int i = 1; i <= 25; i++)
                    {
                        int ranNum = generator.Next(10, 21);
                        numbers.Add(ranNum);
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You chose option 3");
                    Console.WriteLine("Enter the number you want to remove from the list.");
                    int rem = Convert.ToInt32(Console.ReadLine());
                    while(numbers.Remove(rem))

                    Console.ReadLine();

                }
                else if (choice == "4")
                {
                    Console.WriteLine("You chose option 4");
                    Console.WriteLine("Enter the number you want to add to the list.");
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.ReadLine();

                }
                else if (choice == "5")
                {
                    int count = 0;
                    Console.WriteLine("You chose option 5");
                    Console.WriteLine("Enter the number you want to find.");
                    int find = Convert.ToInt32(Console.ReadLine());
                    while (numbers.Contains(find))
                    {
                        count++;
                    }
                    Console.WriteLine(count);
                    Console.ReadLine();

                }
                else if (choice == "6")
                {
                    Console.WriteLine("You chose option 6");
                    numbers.Sort();
                    int count = numbers.Count;
                    count = count - 1;
                    Console.WriteLine(numbers[count]);
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                }
                else if (choice == "7")
                {
                    Console.WriteLine("You chose option 7");
                    numbers.Sort();
                    Console.WriteLine(numbers[0]);
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}
