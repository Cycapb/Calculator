using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CanCalculate()
        {
            var infixString = "2+2";
            var calculator = new Calculator();

            var result = calculator.Calculate(infixString);

            Assert.AreEqual(4, result);
        }
    }
}
