using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class ConverterTests
    {
        private readonly PostfixConverter _converter;
        private readonly Mock<IValidator> _validator;

        public ConverterTests()
        {
            _validator = new Mock<IValidator>();
            _converter = new PostfixConverter(_validator.Object);
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

            var result = _converter.Convert(infixString);

            Assert.AreEqual("22+", result);    
        }
    }
}
