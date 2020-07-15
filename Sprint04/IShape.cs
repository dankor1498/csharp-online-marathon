using System;
using System.Collections.Generic;

namespace Sprint04
{
    interface IShape : ICloneable
    {
        double Area() => 0.0;        
    }

    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area() => Length * Width;
        public object Clone()
        {
            return new Rectangle() { Length = this.Length, Width= this.Width };
        }
    }

    class Trapezoid : IShape
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Width { get; set; }
        public double Area() => (Length1 + Length2) / 2.0 * Width;
        public object Clone()
        {
            return new Trapezoid() { Length1 = this.Length1, Length2 = this.Length2, Width = this.Width };
        }
    }

    class Room<T> : ICloneable, IComparable where T : IShape
    {
        public double Height { get; set; }
        public T Floor { get; set; }

        public object Clone()
        {
            return new Room<T>() { Floor = (T)this.Floor.Clone(), Height = this.Height };
        }

        public int CompareTo(object obj)
        {
            return this.Floor.Area().CompareTo((obj as Room<T>).Floor.Area());
        }

        public double Volume() => Height * Floor.Area();
    }

    class RoomComparerByVolume<T> : IComparer<Room<T>> where T : IShape
    {
        public int Compare(Room<T> x, Room<T> y)
        {
            if (x.Volume() > y.Volume())
                return 1;
            if (x.Volume() < y.Volume())
                return -1;
            return 0;
        }
    }
}
