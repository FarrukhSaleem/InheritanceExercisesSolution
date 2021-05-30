using System;

namespace Ecosystem
{
    public class Dear : Mamal
    {
        public override void Eat()
        {
            Console.WriteLine("The deer eats weed");
        }
        public override void Grow()
        {
            Console.WriteLine("The deer grew to be 80 kgs");
        }
    }
}
