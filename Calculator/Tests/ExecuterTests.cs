using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ExecuterTests
    {
        [TestMethod]
        public void Execute()
        {
            var postfixString = "2 2 + ";
            var executor = new SimpleExecuter();

            var result = executor.Execute(postfixString);

            Assert.AreEqual(4, result);
        }
    }
}
