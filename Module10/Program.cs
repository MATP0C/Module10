using System;

namespace Module10
{
    class Program
    {
        static void Main()
        {
            Console.ReadKey();
        }
    }
    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }
    public class FileManager : IWriter, IReader, IMailer
    {
        void IWriter.Write()
        {

        }
        void IReader.Read()
        {

        }
        void IMailer.SendEmail()
        {

        }
    }
}