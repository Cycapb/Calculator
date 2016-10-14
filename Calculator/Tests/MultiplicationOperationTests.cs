using BusinessLogic.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MultiplicationOperationTests
    {
        private readonly MultiplicationOperation _multiplicationOperation;

        public MultiplicationOperationTests()
        {
            _multiplicationOperation = new MultiplicationOperation();
        }

        [TestMethod]
        public void Execute2Multiplicate2()
        {
            var x = 2;
            var y = 2;
            var result = _multiplicationOperation.Execute(x, y);

            Assert.AreEqual(2, result);
        }
    }
}
