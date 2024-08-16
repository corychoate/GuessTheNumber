using System;

namespace GuessTheNumber
{
    public class RandomNumber
    {
        public int Number {get; private set;}

        public void getNumber()
        {
            Random random = new Random();
            Number = random.Next(1, 100);
        }
    }
}