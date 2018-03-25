using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class AddBinaryUnitTest
    {
        [TestMethod]
        public void AddBinaryTestMethod()
        {
            AddBinary ab = new AddBinary();

            //Assert.AreEqual("100", ab.AddBinarysln("11", "1"));
            Assert.AreEqual("11110", ab.AddBinarysln("1111", "1111"));
        }
    }
}
