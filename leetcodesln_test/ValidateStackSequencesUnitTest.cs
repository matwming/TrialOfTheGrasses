using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class ValidateStackSequencesUnitTest
    {
        public ValidateStackSequences ValidateStackSequences { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ValidateStackSequences = new ValidateStackSequences();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var pushed = new[] { 1, 2, 3, 4, 5 };
            var popped = new[] { 4, 5, 3, 2, 1 };
            var expected = true;
            var actual = ValidateStackSequences.ValidateStackSequencesSln(pushed, popped);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var pushed = new[] { 1, 2, 3, 4, 5 };
            var popped = new[] { 4, 3, 5, 1, 2 };
            var expected = false;
            var actual = ValidateStackSequences.ValidateStackSequencesSln(pushed, popped);
            Assert.AreEqual(expected, actual);
        }
    }
}
