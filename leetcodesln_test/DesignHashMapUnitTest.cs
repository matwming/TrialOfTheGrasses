using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DesignHashMapUnitTest
    {
        [TestMethod]
        public void DesignHashMapTestMethod()
        {
            var myhashmap = new MyHashMap();
            myhashmap.Put(1,1);
            myhashmap.Put(2,2);
            Assert.AreEqual(1, myhashmap.Get(1));
            Assert.AreEqual(-1, myhashmap.Get(3));
            myhashmap.Put(2,1);
            Assert.AreEqual(1, myhashmap.Get(2));
            myhashmap.Remove(2);
            Assert.AreEqual(-1, myhashmap.Get(2));

            var myhashmap2 = new MyHashMap();
            myhashmap2.Remove(1);

        }
    }
}