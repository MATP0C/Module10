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
    public interface IBook
    {
        void Read();
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }
    public class ElectronicBook : IBook, IDevice
    {
        void IBook.Read()
        {

        }
        void IDevice.TurnOn()
        {

        }
        void IDevice.TurnOff()
        {

        }
    }
}