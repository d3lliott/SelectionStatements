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
        }
        
    }
}
