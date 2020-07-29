using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Sprint08
{
    class MainThreadProgram
    {
        public static void Calculator()
        {
            Thread sumThread = new Thread(Sum);
            Thread productThread = new Thread(Product);

            sumThread.Start();
            productThread.Start();

            sumThread.Join();
            productThread.Join();
        }

        public static void Sum()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the {i + 1} number :");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Sum is {sum}");
        }

        public static void Product() =>       
            Console.WriteLine($"Product is {new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Aggregate((a, b) => a * b)}");   
    }
}
