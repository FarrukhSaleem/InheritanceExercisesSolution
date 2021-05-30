using Ecosystem;
using System;
using System.Collections.Generic;

namespace InheritanceExercisesApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateAnimals();
            //MakeAnimalsEat();
            //BreedAnimals();
            //GrowAnimals();
            CreateLivingThings();
            GrowLivingThings();
            Console.ReadLine();
        }

        private static void CreateLivingThings()
        {
            LivingThings = new List<IGrowable>();
            LivingThings.Add(new Lion());
            LivingThings.Add(new Plant());
            LivingThings.Add(new Moose());
            LivingThings.Add(new WhiteTailedDeer());
        }

        private static void GrowLivingThings()
        {
            foreach (IGrowable livingThing in LivingThings)
            {
                livingThing.Grow();
            }
        }

        private static void GrowAnimals()
        {
            foreach (Animal animal in Animals)
            {
                animal.Grow();
            }
        }

        private static void BreedAnimals()
        {
            foreach (Animal animal in Animals)
            {
                animal.Breed();
            }
        }

        private static void MakeAnimalsEat()
        {
            foreach (Animal animal in Animals)
            {
                animal.Eat();
            }
        }

        private static void CreateAnimals()
        {
            Animals = new List<Animal>();
            Animals.Add(new Lion());
            //Animals.Add(new Dear());

            Animals.Add(new Moose());
            Animals.Add(new WhiteTailedDeer());
        }

        private static List<Animal> Animals { get; set; }
        private static List<IGrowable> LivingThings { get; set; }
    }
}
