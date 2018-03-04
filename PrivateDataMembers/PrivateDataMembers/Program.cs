using System;

namespace PrivateDataMembers
{
    class Time
    {
        private int hours, minutes, seconds;  // only accessible through class TIme
        
        public Time(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public Time(int h, int m)
        {
            hours = h;
            minutes = m;
            seconds = 0;
        }
        public Time(int h)
        {
            hours = h;
            minutes = 0;
            seconds = 0;
        }
        private int hour, minute, second;

        public Time() // Default constructor - Not required 
        {
            hour = 0;
            minute = 0;
            second = 0; 
        }
        // properties 

        public int Hour // Property Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }

        public int Minute // Property Hour
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }

        public int Second // Property Hour
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }

        public void setTime(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public override String ToString() //override - yes I know this method already exists, I like mine better and want to use mine instead.
        {
            return hour + ":" + minute + ":" + second;
        }

        public String displayTime()
        {
            return hour + ":" + minute + ":" + second;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Time theTime = new Time();


            theTime.setTime(12, 23, 0);
            Console.WriteLine("The time is " + theTime.displayTime());
            Object obj = new object();
            Console.WriteLine(obj.ToString());
            Console.ReadKey();
        }
    }
}
