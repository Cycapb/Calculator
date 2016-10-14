using System.Configuration;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class OperationProviderTests
    {
        private readonly SimpleOperationProvider _operationProvider;

        public OperationProviderTests()
        {
            _operationProvider = new SimpleOperationProvider();
        }

        [TestMethod]
        public void IsOperationInputPlusReturnsTrue()
        {
            var operation = '+';

            var result = _operationProvider.IsOperation(operation);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsOperationInputAnySymbolReturnsFalse()
        {
            var operation = '$';

            var result = _operationProvider.IsOperation(operation);

            Assert.AreEqual(false, result);
        }
    }
}
