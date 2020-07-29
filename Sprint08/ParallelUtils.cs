using System;
using System.Threading;

namespace Sprint08
{
    public class ParallelUtils<T, TR>
    {
        private Thread thread;

        public ParallelUtils(Func<T, T, TR> function, T param1, T param2)
        {
            thread = new Thread(() => Result = function(param1, param2));
        }

        public TR Result { get; set; }

        public void StartEvaluation() => thread.Start();

        public void Evaluate()
        {
            StartEvaluation();
            thread.Join();
        }
    }
}