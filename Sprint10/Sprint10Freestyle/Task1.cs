using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10Freestyle
{
    namespace Task1
    {
        interface IFlyable
        {
            void Fly();
        }

        interface IEating
        {
            void Eat();
        }

        interface IMoving
        {
            void Move();
        }

        interface IBasking
        {
            void Bask();
        }

        interface IKryaking
        {
            void Krya();
        }

        class Bird : IFlyable, IEating, IMoving
        {
            public virtual void Fly() =>
                Console.WriteLine("I believe, I can fly");

            public virtual void Move() =>
                Console.WriteLine("I can jump!");
            
            public virtual void Eat() =>
                Console.WriteLine("Oh! My corn!");
        }

        class Parrot : Bird, IBasking, IKryaking
        {
            public void Bask() =>
                Console.WriteLine("Chuh-Chuh-Chuh...");

            public void Krya() =>
                Console.WriteLine("Krya-Krya-Krya...");

            public override void Eat() =>
                Console.WriteLine("Oh! My seeds and fruits!");
        }

        class Sparrow : IFlyable, IMoving, IEating
        {
            public void Fly() =>
                Console.WriteLine("I believe, I can fly");

            public void Eat() =>
                Console.WriteLine("Oh! My corn!");

            public void Move() =>
                Console.WriteLine("I can jump!");
        }

        class Duck : Bird, IKryaking
        {
            public void Krya() =>
                Console.WriteLine("Krya-Krya!");

            public override void Move() =>
                Console.WriteLine("I can swimm!");
        }

        class Cat : IMoving, IEating, IBasking
        {
            public void Move() =>
                Console.WriteLine("I can jump!");

            public void Eat() =>
                Console.WriteLine("Oh! My milk!");

            public void Bask() =>
                Console.WriteLine("Mrrr-Mrrr-Mrrr...");
        }
    }
}
