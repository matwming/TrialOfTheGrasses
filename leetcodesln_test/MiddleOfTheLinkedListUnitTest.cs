using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class MiddleOfTheLinkedListUnitTest
    {
        [TestMethod]
        public void MiddleOfTheLinkedListTestMethod()
        {
            var middleOfTheLinkedList = new MiddleOfTheLinkedList();
            ListNode head0 = new ListNode(1);
            ListNode node1 = new ListNode(2);
            ListNode node2 = new ListNode(3);
            ListNode node3 = new ListNode(4);
            ListNode node4 = new ListNode(5);
            head0.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = null;

            var expected = new ListNode(3);
            expected.next = node3;

            var actual = middleOfTheLinkedList.MiddleNode(head0);
            Assert.AreEqual(expected.val, actual.val);
            Assert.AreEqual(expected.next, actual.next);

            ListNode head20 = new ListNode(1);
            ListNode node21 = new ListNode(2);
            ListNode node22 = new ListNode(3);
            ListNode node23 = new ListNode(4);
            ListNode node24 = new ListNode(5);
            ListNode node25 = new ListNode(6);

            head20.next = node21;
            node21.next = node22;
            node22.next = node23;
            node23.next = node24;
            node24.next = node25;
            node25.next = null;

            var expected2 = node23;

            var actual2 = middleOfTheLinkedList.MiddleNode(head20);
            Assert.AreEqual(expected2.val, actual2.val);
            Assert.AreEqual(expected2.next, actual2.next);

        }
    }
}
