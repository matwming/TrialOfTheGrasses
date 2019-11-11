using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class RemoveDuplicatesFromSortedListUnitTest
    {
        public RemoveDuplicatesFromSortedList removeDuplicatesFromSortedList { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            removeDuplicatesFromSortedList = new RemoveDuplicatesFromSortedList();
        }

        [TestMethod, Timeout(10_000)]
        public void RemoveDuplicatesFromSortedListTestMethod1()
        {
            ListNode input = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(3)
                            {
                                next = null
                            }
                        }
                    }
                }
            };

            var expected = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = null
                    }
                }
            };

            var actual = removeDuplicatesFromSortedList.DeleteDuplicates(input);
            try
            {
                while (actual.next != null || expected.next != null)
                {
                    Assert.AreEqual(expected.val, actual.val);
                    expected = expected.next;
                    actual = actual.next;
                }
            }
            catch (Exception e)
            {

                Assert.Fail(e.ToString());
            }
            
        }

        [TestMethod, Timeout(10_000)]
        public void RemoveDuplicatesFromSortedListTestMethod2()
        {
            ListNode input = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(2)
                        {
                            next = null
                        }
                    }
                }
            };

            var expected = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = null
                }
            };

            var actual = removeDuplicatesFromSortedList.DeleteDuplicates(input);
            try
            {
                while (actual.next != null || expected.next != null)
                {
                    Assert.AreEqual(expected.val, actual.val);
                    expected = expected.next;
                    actual = actual.next;
                }
            }
            catch (Exception e)
            {

                Assert.Fail(e.ToString());
            }

        }
    }
}
