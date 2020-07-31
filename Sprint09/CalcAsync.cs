using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Sprint09
{
    public class Calc
    {
        public static int Seq(int n)
        {
            if (n < 0) throw new ArgumentException();
            Thread.Sleep(1000);
            return n * n;
        }
    }

    public static class CalcAsync
    {
        public static async Task PrintSpecificSeqElementsAsync(int[] array)
        {
            Task allTasks = null;
            try
            {
                allTasks = Task.WhenAll(GetSeqAsyncTasksFromArray(array));
                await allTasks;
            }
            catch
            {
                foreach (var inx in allTasks.Exception.InnerExceptions)
                    Console.WriteLine($"Inner exception: {inx.Message}");
            }
        }

        public static List<Task> GetSeqAsyncTasksFromArray(int[] array)
        {
            List<Task> tasks = new List<Task>();
            foreach (var num in array) tasks.Add(Task.Run(() => Console.WriteLine($"Seq[{num}] = {Calc.Seq(num)}")));
            return tasks;
        }

        public static async void PrintStream(IAsyncEnumerable<(int, int)> stream)
        {
            await foreach (var tuple in stream) Console.WriteLine($"Seq[{tuple.Item1}] = {tuple.Item2}");
        }

        public static async IAsyncEnumerable<(int, int)> SeqStreamAsync(int n)
        {
            for (int i = 1; i <= n; i++) yield return (i, await SeqAsync(i));
        }

        public static async Task<int> SeqAsync(int n) => await Task.Run(() => Calc.Seq(n));

        public static async void PrintSeqElementsConsequentlyAsync(int quant)
        {
            for (int i = 1; i <= quant; i++) Console.WriteLine($"Seq[{i}] = {await SeqAsync(i)}");
        }

        public static async Task PrintSeqElementsInParallelAsync(int quant)
        {
            var tasks = await Task.WhenAll(GetSeqAsyncTasks(quant));
            for (int i = 0; i < tasks.Length; i++) Console.WriteLine($"Seq[{i + 1}] = {tasks[i]}");
        }

        public static Task<int>[] GetSeqAsyncTasks(int n)
        {
            Task<int>[] tasks = new Task<int>[n];
            for (int i = 0; i < n; i++) tasks[i] = CalcAsync.SeqAsync(i + 1);
            return tasks;
        }

        public static async void PrintSeqAsync(int n)
        {
            await Task.Run(() => Console.WriteLine($"Seq[{n}] = {Calc.Seq(n)}"));
        }

        public static async Task TaskPrintSeqAsync(int n)
        {
            await Task.Run(() => Console.WriteLine($"Seq[{n}] = {Calc.Seq(n)}"));
        }

        public static void PrintStatusIfChanged(this Task task, ref TaskStatus status)
        {
            if (task.Status != status)
            {
                Console.WriteLine(task.Status);
                status = task.Status;
            }
        }

        public static void TrackStatus(this Task task)
        {
            Console.WriteLine(task.Status);
            TaskStatus status = task.Status;
            while (status != TaskStatus.RanToCompletion) task.PrintStatusIfChanged(ref status);
        }
    }
}
