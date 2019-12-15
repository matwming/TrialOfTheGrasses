using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ConverBinaryNumberInALinkedListToIntegerUnitTest
    {
        public ConverBinaryNumberInALinkedListToInteger ConverBinaryNumberInALinkedListToInteger { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ConverBinaryNumberInALinkedListToInteger = new ConverBinaryNumberInALinkedListToInteger();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var head = new ListNode(1)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(1)
                }
            };
            var expected = 5;
            var actual = ConverBinaryNumberInALinkedListToInteger.GetDecimalValue(head);
            Assert.AreEqual(expected, actual);
        }

    }
}
