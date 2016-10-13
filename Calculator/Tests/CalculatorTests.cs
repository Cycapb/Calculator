using BusinessLogic;
using BusinessLogic.Exceptions;
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
            _converter.Setup(m => m.Convert(It.IsNotNull<string>())).Returns<string>(s => s);

            _calculator.Calculate("22");

            _executer.Verify(m => m.Execute(It.IsAny<string>()),Times.Exactly(1));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputStringException))]
        public void CannotCalculateIfConvertReturnsNull()
        {
            _calculator.Calculate(It.IsAny<string>());
        }
    }
}
