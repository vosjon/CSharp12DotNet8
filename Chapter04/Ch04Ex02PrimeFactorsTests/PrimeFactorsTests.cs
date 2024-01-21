using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests
{
    public class PrimeFactorsTests
    {
        [Fact]
        public void TestPrimeFactorOf4()
        {
            int number = 4;
            string result = PrimeFactors.GetPrimeFactors(number);
            Assert.Equal("2 x 2", result);
        }

        [Fact]
        public void TestPrimeFactorOf30()
        {
            int number = 30;
            string result = PrimeFactors.GetPrimeFactors(number);
            Assert.Equal("2 x 3 x 5", result);
        }
    }
}