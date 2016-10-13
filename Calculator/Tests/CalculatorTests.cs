using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Mock<IConverter> _converter;
        private readonly Mock<IExecuter> _executer;
        private readonly Calculator _calculator;

        [TestMethod]
        public void CanCalculate()
        {

            var infixString = "2+2";
            
            var result = _calculator.Calculate(infixString);

            Assert.AreEqual(4, result);
        }
    }
}
