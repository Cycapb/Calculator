using BusinessLogic.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SubtractionOperationTests
    {
        private readonly SubtractionOperation _subtractionOperation;

        public SubtractionOperationTests()
        {
            _subtractionOperation = new SubtractionOperation();
        }

        [TestMethod]
        public void Execute4Minus2Returns2()
        {
            var x = 4;
            var y = 2;

            var result = _subtractionOperation.Execute(x, y);

            Assert.AreEqual(2, result);
        }
    }
}
