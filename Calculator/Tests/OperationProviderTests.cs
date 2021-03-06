﻿using BusinessLogic;
using BusinessLogic.Operations;
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

        [TestMethod]
        public void GetOperationReturnsAddOperationIfInputIsSymbolPlus()
        {
            var operation = '+';

            var result = _operationProvider.GetOperation(operation);

            Assert.IsInstanceOfType(result, typeof(AddOperation));
        }

        [TestMethod]
        public void GetOperationReturnsNullIfInputIsSymbolDollar()
        {
            var operation = '$';

            var result = _operationProvider.GetOperation(operation);

            Assert.IsNull(result);
        }
    }
}
