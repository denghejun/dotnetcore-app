using System;

namespace service.contract
{
    public class OutputCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            Console.Write(a+b);
            return a+b;
        }
    }
}