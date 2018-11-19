using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class MergeTwoSortedListUnitTest
    {
        [TestMethod]
        public void MergeTwoSortedListTestMethod()
        {
            var mergeTwoSortedList = new MergeTwoSortedList();

            var input1_l1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)
                    {
                        next = null
                    }
                }
            };
            var input1_l2 = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                    {
                        next = null
                    }
                }
            };
            var expected1 = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(4)
                                {
                                    next = null
                                }
                            }
                        }
                    }
                }
            };
            var actual1 = mergeTwoSortedList.MergeTwoLists(input1_l1, input1_l2);

            while(expected1.next!=null && actual1.next!=null)
            {
                Assert.AreEqual(expected1.val, actual1.val);
                expected1 = expected1.next;
                actual1 = actual1.next;
            }

        }
    }
}
