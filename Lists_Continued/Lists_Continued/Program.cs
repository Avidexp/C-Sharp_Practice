using System;
using System.Collections.Generic;

namespace Lists_Continued
{
    class Program
    {
        static void Main(string[] args)
        {
            //random number 
            Random rand = new Random();


            //List<int> numbers = new List<int>();
            //for(int i = 0; i < 100; i++)
            //{
            //    numbers.Add(rand.Next(1,101)); // random number from 1 - 100 
            //}
            //Console.WriteLine("Hello World!");

            //Display(numbers);

            //Searching a list 
            //List<int> numbers = new List<int>();
            //BuildList(numbers);
            //Display(numbers);
            //int item;
            //Console.Write("Enter an item: ");
            //item = Convert.ToInt32(Console.ReadLine());
            //int position = numbers.IndexOf(item);
            //// index of 
            //if(numbers.Contains(item))
            //{
            //    Console.WriteLine(item + " is at position " + position);
            //} else
            //{
            //    Console.WriteLine(item + " not found");
            //}


            //Sorting a list 
            List<int> numbers = new List<int>();
            BuildList(numbers);
            Display(numbers);
            numbers.Sort(); //Ascending order
            Display(numbers);
            numbers.Reverse(); //Descending order 
            Display(numbers);




            Console.ReadKey();
        }
        static void BuildList(List<int> lyst)
        {
            Random rand = new Random();
            for(int i= 0; i < 11; i++)
            {
                lyst.Add(rand.Next(1, 101));
            }

        }


        static void Display(List<int> lyst)
        {
            for(int i = 0; i < lyst.Count; i++)
            {
                if(i % 25 == 0)
                {
                    Console.WriteLine();
                } else
                {
                    Console.Write(lyst[i] + " ");
                }
            }
        }
    }

}
