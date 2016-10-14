using System.CodeDom;
using BusinessLogic.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AddOperationTests
    {
        private readonly AddOperation _addOperation;

        public AddOperationTests()
        {
            _addOperation = new AddOperation();
        }

        [TestMethod]
        public void CanExecute2Plus2()
        {
            var x = 2;
            var y = 2;

            var result = _addOperation.Execute(x,y);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void CanGetPriority()
        {
            var result = _addOperation.GetPriority;

            Assert.AreEqual(2, result);
        }
    }
}
