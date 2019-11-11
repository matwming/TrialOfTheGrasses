using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class LinkedListCycleUnitTest
    {
        public LinkedListCycle LinkedListCycle { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LinkedListCycle = new LinkedListCycle();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var head = new ListNode(3);
            var node1 = new ListNode(2);
            var node2 = new ListNode(0);
            var node3 = new ListNode(-4);
            head.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node1;
            var expected = true;
            var actual = LinkedListCycle.HasCycle(head);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var head = new ListNode(1);
            var node1 = new ListNode(2);
            head.next = node1;
            node1.next = head;
            var expected = true;
            var actual = LinkedListCycle.HasCycle(head);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var head = new ListNode(1);
            var expected = false;
            var actual = LinkedListCycle.HasCycle(head);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var head = new ListNode(1);
            var node1 = new ListNode(2);
            head.next = node1;
            var expected = false;
            var actual = LinkedListCycle.HasCycle(head);
            Assert.AreEqual(expected, actual);
        }
    }
}
