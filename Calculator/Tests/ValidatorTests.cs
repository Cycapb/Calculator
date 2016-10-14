using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class ValidatorTests
    {
        private readonly InfixStringValidator _validator;
        private readonly Mock<IOperationProvider> _operationProvider;

        public ValidatorTests()
        {
            _operationProvider = new Mock<IOperationProvider>();
            _validator = new InfixStringValidator(_operationProvider.Object);
        }

        [TestMethod]
        public void CanValidate2Asd3()
        {
            var infixString = "2Asd3";
            
            var result = _validator.IsValid(infixString);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CanValidate2Plus3()
        {
            var inputString = "2+3";
            _operationProvider.Setup(m => m.IsOperation('+')).Returns(true);

            var result = _validator.IsValid(inputString);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CannotValidateIfStringHasSymbolEquality()
        {
            var inputString = "(2+3)/ (21-10) =";
            _operationProvider.Setup(m => m.IsOperation('+')).Returns(true);
            _operationProvider.Setup(m => m.IsOperation('-')).Returns(true);
            _operationProvider.Setup(m => m.IsOperation('/')).Returns(true);
            _operationProvider.Setup(m => m.IsOperation('(')).Returns(true);
            _operationProvider.Setup(m => m.IsOperation(')')).Returns(true);

            var result = _validator.IsValid(inputString);

            Assert.AreEqual(false, result);
        }
    }
}
