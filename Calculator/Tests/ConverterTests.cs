using BusinessLogic;
using BusinessLogic.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class ConverterTests
    {
        private readonly PostfixConverter _converter;
        private readonly Mock<IValidator> _validator;
        private readonly Mock<IOperationProvider> _operationProvider;

        public ConverterTests()
        {
            _validator = new Mock<IValidator>();
            _operationProvider = new Mock<IOperationProvider>();
            _converter = new PostfixConverter(_validator.Object, _operationProvider.Object);
        }

        [TestMethod]
        public void ConvertReturnsNullIfInputStringIsNullOrEmpty()
        {
            var result = _converter.Convert("");
            
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ConvertReturnsNullIfInputIsInvalid()
        {
            _validator.Setup(m => m.IsValid(It.IsNotNull<string>())).Returns(false);

            var result = _converter.Convert("2s");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void ConvertReturns22PlusIfInput2Plus2()
        {
            var infixString = "2+2";
            _validator.Setup(m => m.IsValid(It.IsNotNull<string>())).Returns(true);
            _operationProvider.Setup(m => m.IsOperation('+')).Returns(true);

            var result = _converter.Convert(infixString);

            Assert.AreEqual("2 2 + ", result);    
        }

        [TestMethod]
        public void Convert2Plus2Div1Plus1()
        {
            var infixString = "(2+2)/(1+1)";
            _validator.Setup(m => m.IsValid(infixString)).Returns(true);
            _operationProvider.Setup(m => m.IsOperation('+')).Returns(true);
            _operationProvider.Setup(m => m.IsOperation('/')).Returns(true);
            _operationProvider.Setup(m => m.GetOperation('+')).Returns(new AddOperation());
            _operationProvider.Setup(m => m.GetOperation('/')).Returns(new DivisionOperation());
            
            var result = _converter.Convert(infixString);

            Assert.AreEqual("2 2 + 1 1 + / ", result);
        }

        [TestMethod]
        public void Convert1Plus2Minus3()
        {
            var infixString = "1+2-3";
            _validator.Setup(m => m.IsValid(infixString)).Returns(true);
            _operationProvider.Setup(m => m.IsOperation('+')).Returns(true);
            _operationProvider.Setup(m => m.IsOperation('-')).Returns(true);
            _operationProvider.Setup(m => m.GetOperation('+')).Returns(new AddOperation());
            _operationProvider.Setup(m => m.GetOperation('-')).Returns(new SubtractionOperation());

            var result = _converter.Convert(infixString);

            Assert.AreEqual("1 2 3 - + ", result);
        }

        [TestMethod]
        public void ConvertReturns44PlusIfInput4SpacePlusSpace4()
        {
            var infixString = "4 + 4";
            _validator.Setup(m => m.IsValid(It.IsNotNull<string>())).Returns(true);
            _operationProvider.Setup(m => m.IsOperation('+')).Returns(true);

            var result = _converter.Convert(infixString);

            Assert.AreEqual("4 4 + ", result);
        }
    }
}
