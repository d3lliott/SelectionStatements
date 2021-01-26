using System;

namespace Selection_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Its time to guess the number! Input an upper limit to start");
                var userResponse = Console.ReadLine();
                var upperLimit = int.Parse(userResponse);
                var r = new Random();
                var number = r.Next(1, upperLimit);
                int guess;
                do
                {
                    Console.WriteLine("Guess a number!");
                    guess = int.Parse(Console.ReadLine());

                    if (guess < number)
                    {
                        Console.WriteLine("Nope! Too low");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Nope! Too high!");
                    }
                    else
                    {
                        Console.WriteLine("You're correct! Good job!");
                    }
                }
                while (guess != number);




                var favSubject = Console.ReadLine();

                switch (favSubject.ToLower())
                {
                    case "math":
                        Console.WriteLine("Nice! You enjoy working with numbers!");
                        break;
                    case "english":
                        Console.WriteLine("You enjoy Literature!");
                        break;
                    case "chemistry":
                        Console.WriteLine("BOOM! Explosions are fun!");
                        break;
                    case "biology":
                        Console.WriteLine("Nature is amazing, good choice!");
                        break;
                    case "history":
                        Console.WriteLine("The past is the key to the future!");
                        break;
                    case "gym":
                        Console.WriteLine("Me too! Being physically active is fun and good for you!");
                        break;
                    default:
                        Console.WriteLine("Oof, we hate that subject. Get a better opinion.");
                        break;
                }
            }

        }
    }
}
