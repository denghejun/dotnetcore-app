using System;
using service.implement;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new ConsoleCalculatorService();
            Console.WriteLine(calculator.Add(99, 88));
            Console.Read();
        }
    }
}
