using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PalindromeLinkedListUnitTest
    {
        public PalindromeLinkedList palindromeLinkedList { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            palindromeLinkedList = new PalindromeLinkedList();
        }

        [TestMethod, Timeout(20_000)]
        public void PalindromeLinkedListTestMethod1()
        {
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = null
                }
            };

            var expected = false;
            var actual = palindromeLinkedList.IsPalindrome(head);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void PalindromeLinkedListTestMethod2()
        {
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(1)
                        {
                            next = null
                        }
                    }
                }
            };

            var expected = true;
            var actual = palindromeLinkedList.IsPalindrome(head);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void PalindromeLinkedListTestMethod3()
        {
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(1)
                            {
                                next = null
                            }
                        }
                    }
                }
            };

            var expected = true;
            var actual = palindromeLinkedList.IsPalindrome(head);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void PalindromeLinkedListTestMethod4()
        {
            var head = new ListNode(1)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(-1)
                    {
                        next = new ListNode(-1)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(1)
                                {
                                    next = null
                                }
                            }
                        }
                    }
                }
            };

            var expected = true;
            var actual = palindromeLinkedList.IsPalindrome(head);
            Assert.AreEqual(expected, actual);
        }
    }
}
