using System;

namespace Week3LogicalOperatorsOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("What Month You Were Born?");
            string Month = Console.ReadLine().ToLower();
            if (Month == "june" || Month == "july" || Month == "august")

            {
                Console.WriteLine("You Were Born In Summer.");
            }
            else if (Month == "december" || Month == "january" || Month == "february")
            {
                Console.WriteLine("You Were Born In Winter.");
            }
            else if (Month == "march" || Month == "april" || Month == "may")
            {
                Console.WriteLine("You Were Born In Spring.");
            }
            else if (Month == "september" ||  Month == "october" || Month == "november" )
            {
                Console.WriteLine("You Were Born In Autumn.");
            }
            else
            {
                Console.WriteLine("This Is Not A Month, Debil.");
            }

        }
    }
}
