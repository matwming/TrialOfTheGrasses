using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FindSmallestLetterGreaterThanTargetUnitTest
    {
        [TestMethod]
        public void FindSmallestLetterGreaterThanTargetTestMethod()
        {
            FindSmallestLetterGreaterThanTarget findSmallestLetterGreaterThanTarget = new FindSmallestLetterGreaterThanTarget();
            Assert.AreEqual('c', findSmallestLetterGreaterThanTarget.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'a'));
            Assert.AreEqual('f', findSmallestLetterGreaterThanTarget.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'c'));
            Assert.AreEqual('f', findSmallestLetterGreaterThanTarget.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'd'));
            Assert.AreEqual('j', findSmallestLetterGreaterThanTarget.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'g'));
            Assert.AreEqual('c', findSmallestLetterGreaterThanTarget.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'j'));
            Assert.AreEqual('c', findSmallestLetterGreaterThanTarget.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'k'));
        }
    }
}
