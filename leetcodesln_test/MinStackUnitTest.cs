using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MinStackUnitTest
    {
        public MinStack MinStack { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MinStack = new MinStack();
        }

        [TestCleanup]
        public void AfterEach()
        {
            MinStack = null;
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            MinStack.Push(-2);
            MinStack.Push(0);
            MinStack.Push(-3);
            Assert.AreEqual(-3, MinStack.GetMin());
            MinStack.Pop();
            Assert.AreEqual(0, MinStack.Top());
            Assert.AreEqual(-2, MinStack.GetMin());
        }

    }
}
