﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
