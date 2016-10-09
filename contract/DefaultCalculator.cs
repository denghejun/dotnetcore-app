namespace service.contract
{
    public class DefaultCalculator : ICalculator
    {
        public int Add(int a, int b) => a + b;
    }
}