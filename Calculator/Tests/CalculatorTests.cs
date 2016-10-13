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

        public CalculatorTests()
        {
            _converter = new Mock<IConverter>();
            _executer = new Mock<IExecuter>();
            _calculator = new Calculator(_converter.Object,_executer.Object);
        }


        [TestMethod]
        public void CanCalculate()
        {
            _converter.Setup(m => m.Convert(It.IsAny<string>())).Returns(It.IsNotNull<string>());

            _calculator.Calculate("");

            _executer.Verify(m => m.Execute(It.IsAny<string>()),Times.Exactly(1));
        }
    }
}
