using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string subject = "engineering";

            Console.WriteLine("Hello Please enter a favorite subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "engineering":
                    Console.WriteLine("Your favorite subject is engineering.");
                    break;
                case "english":
                    Console.WriteLine("Your favorite subject is english");
                    break;
                case "arts":
                    Console.WriteLine("Your favorite subject is arts");
                    break;
                case "mathematics":
                    Console.WriteLine("Your favorite subject is mathematics");
                    break;
                case "history":
                    Console.WriteLine("Your favorite subject is history");
                    break;
                default:
                    Console.WriteLine("We don not offer your subject of choice.");
                    break;
            }
        }

    }
}
