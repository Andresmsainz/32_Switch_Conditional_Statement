using System;

namespace _32_Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch Statements!");
            Console.WriteLine("");

            Console.WriteLine("Are you ready to take over the world with C# and ASP?");
            string answer = Console.ReadLine();

            switch (answer.ToUpper())
            {
                case "YES":
                    Console.WriteLine("It's about freaking time... let's do it!");
                    break;
                case "NO":
                    Console.WriteLine("Let's regroup and figure something out!");
                    break ;
                case "MAYBE":
                    Console.WriteLine("I can't accept that answer... how bad do you want it?");
                    break;
                default:
                    Console.WriteLine("I'm not sure what you mean... but I know something has to change!");
                    break;
            }
        }
    }
}
