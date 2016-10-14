using BusinessLogic.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class LeftBracketOperationTests
    {
        private readonly LeftBracketOperation _leftBracketOperation;

        public LeftBracketOperationTests()
        {
            _leftBracketOperation = new LeftBracketOperation();
        }

        [TestMethod]
        public void GetPriority()
        {
            var result = _leftBracketOperation.GetPriority;

            Assert.AreEqual(0, result);
        }
    }
}
