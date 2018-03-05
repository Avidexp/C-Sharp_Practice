using System;
using System.Collections.Generic;

namespace CustomSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("How many items would you like in the list? ");
            int count = Convert.ToInt32(Console.ReadLine());
            BuildList(numbers, count);
            Display(numbers);
            Console.WriteLine();
            Console.WriteLine("What would you like to find? ");
            int item = Convert.ToInt32(Console.ReadLine());

            List<int> foundItems = new List<int>();
            foundItems = search(numbers, item);
            Display(foundItems);
            Console.ReadKey();

        }

        static List<int> search(List<int> lyst, int item)
        {
            int foundAt, pos;
            pos = 0;
            List<int> items = new List<int>();

            foundAt = lyst.IndexOf(item, pos);
            items.Add(foundAt);
            while(foundAt > -1)
            {
                pos = foundAt + 1;
                foundAt = lyst.IndexOf(item, pos);
                if(foundAt > -1)
                {
                    items.Add(foundAt);
                  }
            }

            return items;

        }

        static void BuildList(List<int> lyst, int numItems)
        {
            Random rand = new Random();
            for (int i = 0; i <numItems; i++)
            {
                lyst.Add(rand.Next(1, 101));
            }

        }


        static void Display(List<int> lyst)
        {
            for (int i = 0; i < lyst.Count; i++)
            {
                if (i % 25 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(lyst[i] + " ");
                }
            }
        }
    }
}
