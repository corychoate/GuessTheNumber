using System;
using System.Runtime.CompilerServices;

namespace GuessTheNumber
{
    
    public class Game
    {
        Player Player = new Player();
        RandomNumber RandomNumber = new RandomNumber();

        public void Start()
        {
            Player.getName();
            Console.WriteLine("The goal of the game is to guess the number (between 1 and 100)");
            Console.WriteLine();

            RandomNumber.getNumber();
            int numberToGuess = RandomNumber.Number;
            bool isGuessCorrect = false;

            while (!isGuessCorrect)
            {
                Player.playerGuess();
                
                if (Player.guess == numberToGuess)
                {
                    isGuessCorrect = true;
                    Console.WriteLine($"Congrats {Player.name}, you win!");
                }
                else if (Player.guess < numberToGuess)
                {
                    Console.WriteLine("Guess higher");
                    Console.WriteLine();
                }
                else if (Player.guess > numberToGuess)
                {
                    Console.WriteLine("lower");
                    Console.WriteLine();
                }
            }
        }
    }
}