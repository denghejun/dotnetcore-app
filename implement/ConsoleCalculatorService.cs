using service.contract;
namespace service.implement
{
    public class ConsoleCalculatorService : ICalculator
    {
        public int Add(int a, int b) => a + b;
    }
}