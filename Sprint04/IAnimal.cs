using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint04
{
    interface IAnimal
    {
        public string Name { get; set; }
        void Voice();
        void Feed();
    }
    class Cat : IAnimal
    {
        public string Name { get; set; }
        public void Voice() => Console.WriteLine("Mew");
        public void Feed() => Console.WriteLine("I eat mice");
    }

    class Dog : IAnimal
    {
        public string Name { get; set; }
        public void Voice() => Console.WriteLine("Woof");
        public void Feed() => Console.WriteLine("I eat meat");
    }
}
