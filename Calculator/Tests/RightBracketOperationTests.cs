using BusinessLogic.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class RightBracketOperationTests
    {
        private readonly RightBracketOperation _rightBracketOperation;

        public RightBracketOperationTests()
        {
            _rightBracketOperation = new RightBracketOperation();
        }

        [TestMethod]
        public void GetPriorityReturns1()
        {
            var result = _rightBracketOperation.GetPriority;

            Assert.AreEqual(1, result);
        }
    }
}
