using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //calling method 
            char state = 'y';

            while (state == 'y')
            {
                Console.WriteLine("What is the number? ");
                double num = Convert.ToDouble(Console.ReadLine());

                Console.Write(num + " squared is: " + square(num));

                Console.WriteLine();
                Console.Write("Continue (y/n)?");
                state = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter a Fahrenheit temperature: ");
                double temp = Convert.ToDouble(Console.ReadLine());

                Console.Write(temp + "F, equals ");
                Console.WriteLine(ftoc(temp) + "C.");

                Console.ReadKey();
            }



        }

        // methods - outside of main. Static means it exists by itself, not part of larger class
        //static {return type} {name of method} (parameters)

        static double square(double number)
        {
            return number * number;
        }

        //Defining a method 

        static double ftoc(double temp)
        {
            return (temp - 32.0) * (5.0 / 9.0);
        }

        static double ctof(double temp)
        {
            return (temp * 9 / 5) + 32.0;
        }
        
    }
}
