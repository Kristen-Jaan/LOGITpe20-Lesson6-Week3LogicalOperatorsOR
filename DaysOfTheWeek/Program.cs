using System;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("What Day Is Today?");
            string Day = Console.ReadLine().ToLower();
            if(Day == "monday" || Day == "tuesday" || Day == "wednesday" || Day == "thursday" || Day == "friday")
            {
                Console.WriteLine($"{Day} Is A Workday.");
            }
            else if(Day == "saturday" || Day == "sunday")
            {
                Console.WriteLine("It's Weekend!");
            }
            else
            {
                Console.WriteLine("This Is Not A Day Of The Week, Debil.");
            }

        }
    }
}
