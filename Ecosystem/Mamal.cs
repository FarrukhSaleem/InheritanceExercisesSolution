using System;

namespace Ecosystem
{
    public abstract class Mamal : Animal
    {
        public override void Breed()
        {
            Console.WriteLine("One offspring produced.");
        }
    }
}
