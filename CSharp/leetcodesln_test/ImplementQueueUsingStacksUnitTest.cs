using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ImplementQueueUsingStacksUnitTest
    {
        public ImplementQueueUsingStacks myQueue { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            myQueue = new ImplementQueueUsingStacks();
        }

        [TestCleanup]
        public void AfterEach()
        {
            myQueue = new ImplementQueueUsingStacks();
        }

        [TestMethod, Timeout(10_000)]
        public void ImplementQueueUsingStacksTestMethod1()
        {
            myQueue.Push(1);
            myQueue.Push(2);
            Assert.AreEqual(1, myQueue.Peek());
            Assert.AreEqual(1, myQueue.Pop());
            Assert.IsFalse(myQueue.Empty());
        }
    }
}
