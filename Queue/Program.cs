using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int>()
            {
                1, 3, 3, 4
            };

            var intQueue = new Queue<int>(myList);

            Console.WriteLine(intQueue.Count);
            Console.WriteLine(intQueue.Remove());
            Console.WriteLine(intQueue.Count);

            intQueue.Add(5);

            Console.WriteLine(intQueue.Count);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
