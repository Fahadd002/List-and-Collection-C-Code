using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListTask01();
            Console.WriteLine("\n***********************");
            ListTask02();
            Console.ReadLine();
        }
        public static void ListTask01()
        {
            // Create a list of integers
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            // Add an element to the list
            numbers.Add(6);

            // Remove an element from the list
            numbers.Remove(3);

            // Access elements by index
            Console.WriteLine("First element: " + numbers[0]);
            Console.WriteLine("Second element: " + numbers[1]);

            // Iterate through the list
            Console.WriteLine("All elements in the list:");
            foreach (int n in numbers)
            {
                Console.Write($"{n},");
            }
        }
        public static void ListTask02() {
            // Create a list of integers
            List<int> numbers = new List<int>() { 5, 3, 8, 1, 2 };

            // Add multiple elements to the list
            numbers.AddRange(new int[] { 7, 6, 4 });

            // Sort the list
            numbers.Sort();

            // Find an element in the list
            int index = numbers.IndexOf(4);
            Console.WriteLine("Index of 4: " + index);

            // Check if the list contains a specific element
            bool containsFive = numbers.Contains(5);
            Console.WriteLine("List contains 5: " + containsFive);

            // Use LINQ to find all even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even numbers:");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Use LINQ to find the sum of all numbers
            int sum = numbers.Sum();
            Console.WriteLine("Sum of all numbers: " + sum);

            // Iterate through the sorted list
            Console.WriteLine("All elements in the sorted list:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
