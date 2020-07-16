using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint05
{
    class MyProgram
    {
        public static void Position(List<int> numbers)
        {            
            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] == 5)
                    Console.WriteLine(i + 1);
        }

        public static void Remove(List<int> numbers)
        {
            numbers.RemoveAll(item => item > 20);
            numbers.ForEach(item => Console.WriteLine(item));
        }

        public static void Insert(List<int> numbers)
        {
            numbers.Insert(2, -5);
            numbers.Insert(5, -6);
            numbers.Insert(7, -7);
            numbers.ForEach(item => Console.WriteLine(item));
        }

        public static void Sort(List<int> numbers)
        {
            numbers.Sort();
            numbers.ForEach(item => Console.WriteLine(item));
        }
    }
}
