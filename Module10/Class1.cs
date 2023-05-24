using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Calculator1 : ICalculator
    {
        ILogger Logger { get;}
        public Calculator1(ILogger logger)
        {
            Logger = logger;
        }
        public void Sum()
        {
            Logger.Event("Калькулятор начал свою работу...");
            Thread.Sleep(3000);
            Logger.Event("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Logger.Event("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            Logger.Event("Результат вычислений:");
            double total = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, total);
            return;
        }
    }
}
