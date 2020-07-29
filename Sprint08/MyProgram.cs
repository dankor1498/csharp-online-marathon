using System;
using System.Threading;

namespace Sprint08
{
    public class MyProgram
    {
        public static void Counter(int n)
        {
            Thread factorialThread = new Thread(() => Console.WriteLine($"Factorial is: {Factorial(n)}"));
            factorialThread.Start();
            factorialThread.Join();

            Thread fibonacciThread = new Thread(() => Console.WriteLine($"Fibbonaci number is: {Fibbonaci(n)}"));
            fibonacciThread.Start();
            fibonacciThread.Join();
        }

        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        public static int Fibbonaci(int n)
        {
            if ((n == 0) || (n == 1)) return n;
            return Fibbonaci(n - 1) + Fibbonaci(n - 2);
        }
    }
}
