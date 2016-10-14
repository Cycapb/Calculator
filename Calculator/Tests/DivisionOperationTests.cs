using System;
using BusinessLogic.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class DivisionOperationTests
    {
        private readonly DivisionOperation _divOperation;

        public DivisionOperationTests()
        {
            _divOperation = new DivisionOperation();
        }

        [TestMethod]
        public void CanExecute4Div2()
        {
            var result = _divOperation.Execute(4, 2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CannotExecuteThrowsDivideByZeroException()
        {
            _divOperation.Execute(2, 0);
        }

        [TestMethod]
        public void GetPriorityReturns4()
        {
            var result = _divOperation.GetPriority;

            Assert.AreEqual(4, result);
        }
    }
}
