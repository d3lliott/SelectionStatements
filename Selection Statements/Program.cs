using System;

namespace Selection_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 41;
            var r = int.Parse(Console.ReadLine());
            if (r < favNumber)
            {
                Console.WriteLine("Nope! Too low");
            }
            else if (r > favNumber)
            {
                Console.WriteLine("Nope! Too high!");
            }
            else
            {
                Console.WriteLine("You're correct! Good job!");
            }

            var favSubject = Console.ReadLine();
            
            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("Nice! You enjoy working with numbers!");
                    break;
                case "English":
                    Console.WriteLine("You enjoy Literature!");
                    break;
                case "Chemistry":
                    Console.WriteLine("BOOM! Explosions are fun!");
                    break;
                case "Biology":
                    Console.WriteLine("Nature is amazing, good choice!");
                    break;
                case "History":
                    Console.WriteLine("The past is the key to the future!");
                    break;
                case "Gym":
                    Console.WriteLine("Me too! Being physically active is fun and good for you!");
                    break;
                default:
                    Console.WriteLine("Oof, we hate that subject. Get a better opinion.");
                    break;
             }
        }
           
    }
}
