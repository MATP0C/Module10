using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Module10
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var calculator1 = new Calculator1(Logger);
            while(true)
            {
                try
                {
                    calculator1.Sum();
                }
                catch (ArgumentNullException)
                {
                    Logger.Error("Аргумент передоваемый в метод не имеет значения");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Logger.Error("Аргумент находится за пределами диапозона допустимых значений");
                }
                catch (OverflowException)
                {
                    Logger.Error("Арифметическая операция приводит к переполнению");
                }
                catch (FormatException)
                {
                    Logger.Error("Значение не находится в соответсвующем формате");
                }
                finally
                {
                    Console.WriteLine("Повторите попытку снова");
                }
            }
        }
    }

    public interface ICalculator
    {
        void Sum();
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}