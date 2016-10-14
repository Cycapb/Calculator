using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ValidatorTests
    {
        private readonly InfixStringValidator _validator;

        public ValidatorTests()
        {
            _validator = new InfixStringValidator();
        }

        [TestMethod]
        public void CanValidate2Asd3()
        {
            var infixString = "2Asd3";

            var result = _validator.IsValid(infixString);

            Assert.AreEqual(false, result);
        }
    }
}
