using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {

        static void Main(string[] args)
        {

            //List<int> grades = new List<int>(); //new list object 
            //grades.Add(89);
            //grades.Add(78);
            //grades.Add(92);
            //double average = grades.Sum() / grades.Count();
            //Console.WriteLine("The average is " + average);

            //Declaring a list 

            //List<int> number = new List<int>();
            //// List <dat type> name = new List<data type>();
            //List<string> names = new List<string>();
            //List<Boolean> flags = new List<Boolean>();
            //List<char> letters = new List<char>();
            //number.Capacity = 10; // max number of items in list - setting capacity helps meomry + efficiency 

            // initializing a list 

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<string> names = new List<string>() { "Dylan", "Jack", "John", "bill" };


            //adding data to a list 

            ////List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //for(int i= 3; i < 10; i++)
            //{
            //    numbers.Add(i);
            //}

            //accessing list items 
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(numbers[0] + " " + numbers[1]);
            int sum = 0;

            for(int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("The sum is " + sum);
            List<string> names = new List<string>() { "Dylan", "Jack", "John", "bill" };
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            //passing lists to methods 


            List<int> grades = new List<int>() { 50, 60, 70, 80, 90, 100 };
            DisplayList(grades);
            Console.Write("The average of the grades is ");
            Console.WriteLine(average(grades));
            Console.WriteLine();
            curveGrades(grades);
            DisplayList(grades);

            Console.ReadKey();

        }

        static void DisplayList(List<int> lyst)
        {
            for(int i = 0; i < lyst.Count; ++i)
            {
                Console.WriteLine(lyst[i]);
            }
        }

        static double average(List<int> lyst)
        {
            int sum = lyst.Sum();
            return sum / lyst.Count;
        }

        static void curveGrades(List<int> lyst)
        {
            for(int i =0; i < lyst.Count; i++)
            {
                lyst[i] += 5;
            }
        }
    }
}
