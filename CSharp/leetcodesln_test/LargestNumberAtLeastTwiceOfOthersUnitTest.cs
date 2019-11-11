using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LargestNumberAtLeastTwiceOfOthersUnitTest
    {
        [TestMethod]
        public void LargestNumberAtLeastTwiceOfOthersTestMethod()
        {
            LargestNumberAtLeastTwiceOfOthers largestNumberAtLeastTwiceOfOthers = new LargestNumberAtLeastTwiceOfOthers();
            //Assert.AreEqual(1,largestNumberAtLeastTwiceOfOthers.DominantIndex(new int[] { 3,6,1,0}));
            //Assert.AreEqual(-1,largestNumberAtLeastTwiceOfOthers.DominantIndex(new int[] { 1,2,3,4}));
            //Assert.AreEqual(3,largestNumberAtLeastTwiceOfOthers.DominantIndex(new int[] { 0,0,0,1}));
            Assert.AreEqual(0,largestNumberAtLeastTwiceOfOthers.DominantIndex(new int[] {1}));
        }
    }
}
