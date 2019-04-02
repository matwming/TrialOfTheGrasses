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

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            MinStack.Push(2147483646);
            MinStack.Push(2147483646);
            MinStack.Push(2147483647);
            Assert.AreEqual(2147483647, MinStack.Top());
            MinStack.Pop();
            Assert.AreEqual(2147483646, MinStack.GetMin());
            MinStack.Pop();
            Assert.AreEqual(2147483646, MinStack.GetMin());
            MinStack.Pop();
            MinStack.Pop();
            MinStack.Push(2147483647);
            Assert.AreEqual(2147483647, MinStack.Top());
            Assert.AreEqual(2147483647, MinStack.GetMin());
            MinStack.Push(-2147483648);
            Assert.AreEqual(-2147483648, MinStack.Top());
            Assert.AreEqual(-2147483648, MinStack.GetMin());
            MinStack.Pop();
            Assert.AreEqual(2147483647, MinStack.GetMin());

        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            MinStack.Push(-10);
            MinStack.Push(14);
            Assert.AreEqual(-10, MinStack.GetMin());
            Assert.AreEqual(-10, MinStack.GetMin());

            MinStack.Push(-20);
            Assert.AreEqual(-20, MinStack.GetMin());
            Assert.AreEqual(-20, MinStack.GetMin());
            Assert.AreEqual(-20, MinStack.Top());
            Assert.AreEqual(-20, MinStack.GetMin());
            MinStack.Pop();
            MinStack.Push(10);
            MinStack.Push(-7);
            Assert.AreEqual(-10, MinStack.GetMin());
            MinStack.Push(-7);
            MinStack.Pop();
            Assert.AreEqual(-7, MinStack.Top());
            Assert.AreEqual(-10, MinStack.GetMin());
            MinStack.Pop();
        }
    }
}
