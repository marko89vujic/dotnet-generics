
using System;

namespace CoffeeAppGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();
            Console.ReadLine();
        }

        private static void StackDoubles()
        {
            var simpleStack = new SimpleStack<double>();
            simpleStack.Push(1.2);
            simpleStack.Push(4.6);
            simpleStack.Push(7.1);

            var sum = 0.0;

            while (simpleStack.Count > 0)
            {
                var item = simpleStack.Pop();
                Console.WriteLine($"Items: {item}");
                sum += item;
            }

            Console.Write($"Sum: {sum}");
        }

        private static void StackStrings()
        {
            var simpleStack = new SimpleStack<string>();

            simpleStack.Push("marko");
            simpleStack.Push("katarina");
            simpleStack.Push("sofija");

            while (simpleStack.Count>0)
            {
                var item = simpleStack.Pop();
                Console.WriteLine($"{item}");
            }
        }
    }
}
