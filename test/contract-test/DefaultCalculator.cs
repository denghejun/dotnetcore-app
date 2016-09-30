using System;
using service.contract;
using Xunit;

namespace contract.test
{
    public class DefaultContractTest
    {
        [Fact]
        public void TestMockSuccess()
        {
            var cal = new DefaultCalculator();
            var res = cal.Add(1, 2);
            Assert.Equal(3, res);
        }

        [Fact]
        public void TestMockFail()
        {
            var cal = new OutputCalculator();
            var res = cal.Add(1, 2);
            Assert.Equal(7, res);
        }
    }
}