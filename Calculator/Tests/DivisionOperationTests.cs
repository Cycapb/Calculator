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
    }
}
