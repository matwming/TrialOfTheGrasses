using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class RemoveLinkedListElementsUnitTest
    {
        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            Type type = typeof(RemoveLinkedListElements);
            var removeLinkedListElements = Activator.CreateInstance(type);

            MethodInfo method = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(x => x.Name == "RemoveElements" && x.IsPrivate)
                .First();

            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(5)
                                {
                                    next = new ListNode(6)
                                    {
                                        next = null
                                    }
                                }
                            }
                        }
                    }
                }
            };
            var val = 6;
            var expected = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };

            var actual = (ListNode)method.Invoke(removeLinkedListElements,new object[] { head, val});

            while (expected.next!=null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }

    }
}
