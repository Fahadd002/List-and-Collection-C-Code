
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_works
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<T> - Generic collection
            List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };
            fruits.Add("Date");
            Console.WriteLine("List<T>:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Dictionary<TKey, TValue> - Key/Value pair collection
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Alice");
            students.Add(2, "Bob");
            Console.WriteLine("\nDictionary<TKey, TValue>:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }

            // Stack<T> - LIFO collection
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("\nStack<T>:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            // Queue<T> - FIFO collection
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            Console.WriteLine("\nQueue<T>:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            // ArrayList - Non-generic collection
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Two");
            arrayList.Add(3.0);
            Console.WriteLine("\nArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
