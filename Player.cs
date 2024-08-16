using System;

namespace GuessTheNumber
{
    public class Player()
    {
        RandomNumber randomNumber = new RandomNumber();
        public string ? name {get; private set;}

        public void getName()
        {
            Console.WriteLine();
            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}");
            Console.WriteLine();
        }



        public int guess {get; private set;}

        public void playerGuess()
        {

            Console.WriteLine("What is your guess?");
            string ? input = Console.ReadLine();
            guess = int.Parse(input ?? "0");

        }

    }
}