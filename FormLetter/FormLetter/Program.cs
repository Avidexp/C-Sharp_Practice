using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, present, yourName;
            int age;
            Console.Write("What is the name of the gift giver? ");
            name = Console.ReadLine();
            Console.Write("What is the gift? ");
            present = Console.ReadLine();
            Console.Write("How old were you on your birthday? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your name? ");
            yourName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dear {0}, ", name);
            Console.WriteLine();
            Console.Write("Thank you for the {0}. ", present);
            Console.WriteLine("I really like it. I can't believe ");
            Console.Write("I'm already " + age + " years old, but ");
            Console.WriteLine("it doesn't feel that much different than ");
            Console.WriteLine("being " + (age - 1) + ". ");
            Console.WriteLine();
            Console.WriteLine("Sincerely, ");
            Console.WriteLine();
            Console.WriteLine(yourName);
            Console.ReadKey();
        }
    }
}
