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
    }
}
