using System;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
    public interface IWorker
    {
        public void Build();
    }
    public class Worker : IWorker
    {
        public void Build()
        {

        }
    }
}