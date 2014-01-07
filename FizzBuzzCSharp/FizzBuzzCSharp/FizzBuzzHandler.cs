﻿namespace FizzBuzzCSharp
{
    public class FizzBuzzHandler : WordHandler
    {
        private readonly WordHandler successor = new FizzHandler();

        public FizzBuzzHandler(WordHandler successor) : base(successor)
        {
        }

        public override string Handle(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            return successor.Handle(number);
        }
    }
}