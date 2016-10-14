using BusinessLogic;
using BusinessLogic.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class ExecuterTests
    {
        private readonly Mock<IOperationProvider> _operationProvider;
        private readonly SimpleExecuter _executor;

        public ExecuterTests()
        {
            _operationProvider = new Mock<IOperationProvider>();
            _executor = new SimpleExecuter(_operationProvider.Object);
        }

        [TestMethod]
        public void Execute2Plus2()
        {
            var postfixString = "2 2 + ";
            _operationProvider.Setup(m => m.IsOperation('+')).Returns(true);
            _operationProvider.Setup(m => m.GetOperation('+')).Returns(new AddOperation());

            var result = _executor.Execute(postfixString);

            Assert.AreEqual(4, result);
        }
    }
}
