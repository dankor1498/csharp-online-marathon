using System;

namespace Sprint04
{
    namespace Task1
    {
        internal interface ISwimmable
        {
            void Swim() => Console.WriteLine("I can swim!");
        }

        internal interface IFlyable
        {
            int MaxHeight { get; }
            void Fly() => Console.WriteLine($"I can fly at {MaxHeight} meters height!");
        }

        internal interface IRunnable
        {
            int MaxSpeed { get; }
            void Run() => Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
        }

        internal interface IAnimal
        {
            int LifeDuration { get; }
            void Voice() => Console.WriteLine("No voice!");
            void ShowInfo() => Console.WriteLine($"I am a {GetType()} and I live approximately {LifeDuration} years.");
        }

        internal class Cat : IAnimal, IRunnable
        {
            public int LifeDuration { get; set; }
            public int MaxSpeed { get; set; }
            public void Voice() => Console.WriteLine("Meow!");
        }

        internal class Eagle : IAnimal, IFlyable
        {
            public int LifeDuration { get; set; }
            public int MaxHeight { get; set; }
        }

        internal class Shark : IAnimal, ISwimmable
        {
            public int LifeDuration { get; set; }
        }
    }    
}