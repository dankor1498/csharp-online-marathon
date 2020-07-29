﻿using System;
using System.Threading;

namespace Sprint08
{
    public class MyThreads
    {
        public static readonly object Den = new object();
        public static readonly object Ada = new object();
        public static int n;
        public static int m;

        public static Thread Thread1 = new Thread(() =>
        {
            lock (Den)
            {
                for (int i = 0; i < 5; i++, n++) Console.WriteLine("Thread1 n = " + n);
            }

            Thread.Sleep(100);
            for (int i = 0; i < 5; i++, m++) Console.WriteLine("Thread1 m = " + m);
            Console.WriteLine("Thread1 success!");
        });

        public static Thread Thread2 = new Thread(() =>
        {
            lock (Ada)
            {
                lock (Den)
                {
                    for (int i = 0; i < 5; i++, m++) Console.WriteLine("Thread2 m = " + m);
                    for (int i = 0; i < 5; i++, n++) Console.WriteLine("Thread2 n = " + n);
                    Console.WriteLine("Thread2 success!");
                }
            }
        });
    }
}

//class MyThreads
//{
//    public static readonly object Den = new object();
//    public static readonly object Ada = new object();

//    public static int n;
//    public static int m;

//    public Thread Thread1 = new Thread(
//        () =>
//        {
//            lock (Den)
//            {
//                for (int i = 0; i < 5; i++, n++)
//                {
//                    Console.WriteLine("Thread1 n = " + n);
//                    ThreadsDemo.ExtraEvaluation(i);
//                }

//                Thread.Yield();

//                lock (Ada)
//                {
//                    for (int i = 0; i < 5; i++, m++)
//                        Console.WriteLine("Thread1 m = " + m);
//                    Console.WriteLine("Thread1 success!");
//                }
//            }
//        }
//    );

//    public Thread Thread2 = new Thread(
//        () =>
//        {
//            lock (Ada)
//            {
//                for (int i = 0; i < 5; i++, m++)
//                    Console.WriteLine("Thread2 m = " + m);
//                Thread.Yield();
//                lock (Den)
//                {
//                    for (int i = 0; i < 5; i++, n++)
//                        Console.WriteLine("Thread2 n = " + n);
//                    Console.WriteLine("Thread2 success!");
//                }
//            }
//        }
//    );
//}