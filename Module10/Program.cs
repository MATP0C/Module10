using System;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            ((IWorker)worker).Build();
            Console.ReadKey();
        }
    }
    public interface IWorker
    {
        public void Build();
    }
    public class Worker : IWorker
    {
        void IWorker.Build()
        {

        }
    }
}