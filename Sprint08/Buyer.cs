using System;
using System.Threading;

namespace Sprint08
{
    public class PersonInTheShop
    {
        public void Enter() => Console.WriteLine("Enter");

        public void SelectGroceries() => Console.WriteLine("Select groceries");

        public void Pay() => Console.WriteLine("Pay");

        public void Leave() => Console.WriteLine("Leave");
    }

    public class Buyer : PersonInTheShop
    {
        private static readonly Semaphore Semaphore = new Semaphore(10, 10);

        public Buyer(string threadName)
        {
            Thread myThread = new Thread(Shop) {Name = threadName};
            myThread.Start();
        }

        private void Shop()
        {
            Semaphore.WaitOne();
            base.Enter();
            base.SelectGroceries();
            base.Pay();
            base.Leave();
            Semaphore.Release();
        }
    }
}