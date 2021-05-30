using System;

namespace Ecosystem
{
    public class Plant : IGrowable
    {
        public void Grow()
        {
            Console.WriteLine("The plant grew to be 10 meters tall");
        }
    }
}
