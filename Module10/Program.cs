using System;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();
            ((IWriter)writer).Write();
            Console.ReadKey();
        }
    }
    public interface IWriter
    {
        void Write();
    }
    public class Writer : IWriter 
    {
        void IWriter.Write()
        {

        }
    }
}