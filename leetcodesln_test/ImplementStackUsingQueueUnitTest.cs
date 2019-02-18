using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ImplementStackUsingQueueUnitTest
    {
        public ImplementStackUsingQueue ImplementStackUsingQueue { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ImplementStackUsingQueue = new ImplementStackUsingQueue();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            ImplementStackUsingQueue.Push(1);
            ImplementStackUsingQueue.Push(2);
            Assert.AreEqual(2, ImplementStackUsingQueue.Top());
            Assert.AreEqual(2, ImplementStackUsingQueue.Pop());
            Assert.IsFalse(ImplementStackUsingQueue.Empty());
        }
    }
}
