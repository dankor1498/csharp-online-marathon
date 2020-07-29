using System;
using System.Threading.Tasks;

namespace Sprint08
{
    public class MyTasks
    {
        private static void PrintArray(int[] array, string end)
        {
            foreach (var item in array)
                Console.WriteLine(item);
            Console.WriteLine(end);
        }

        private static void PrintIndex(int length, string end)
        {
            for (int i = 0; i < length; i++)
                Console.WriteLine(i);
            Console.WriteLine(end);
        }

        private static void ChangeArray(int[] array, string end)
        {
            for (int i = 0; i < array.Length; i++) 
                array[i] = i * i;
            Console.WriteLine(end);
        }

        public static void Tasks()
        {
            int[] sequenceArray = new int[10];

            Task task1 = new Task(() => ChangeArray(sequenceArray, "Calculated!"));
            Task task2 = task1.ContinueWith((t) => PrintIndex(sequenceArray.Length, "Bye!"))
                .ContinueWith((t) => PrintArray(sequenceArray, "Bye!"));

            task1.Start();
            task2.Wait();

            Console.WriteLine("Main done!");
        }
    }
}