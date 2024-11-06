using System;

namespace DeveloperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Is Admin: " + isAdmin);

            // Task 2 
            Console.Write("\nEnter an integer:");
           int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


          // Task 3 
            Console.WriteLine("\nNumbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


         // Task 4 
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            Console.WriteLine("\nArray elements:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                sum += number;
            }
            Console.WriteLine("Sum of array elements: " + sum);



            // Task 5
            Greet("Alice");
        }
       static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
