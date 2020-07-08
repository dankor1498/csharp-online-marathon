using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint02
{
    abstract class Car
    {
        internal string mark;
        internal int prodYear;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Mark : {mark},\nProducted in {prodYear}");
        }
    }

    class SportCar : Car
    {
        private int maxSpeed;

        public SportCar(string mark, int prodYear, int maxSpeed)
        {
            this.mark = mark;
            this.prodYear = prodYear;
            this.maxSpeed = maxSpeed;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Maximum speed is {maxSpeed}");
        }
    }

    class Lory : Car
    {
        private double loadCapacity;

        public Lory(string mark, int prodYear, double loadCapacity)
        {
            this.mark = mark;
            this.prodYear = prodYear;
            this.loadCapacity = loadCapacity;
        }
        
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"The load capacity is {loadCapacity}");
        }
    }
}
