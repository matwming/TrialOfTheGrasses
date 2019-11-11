using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class BinaryWatchUnitTest
    {
        [TestMethod]
        public void BinaryWatchTestMethod()
        {
            BinaryWatch binaryWatch = new BinaryWatch();
            string[] sample = { "1:00", "2:00", "4:00", "8:00", "0:01", "0:02", "0:04", "0:08", "0:16", "0:32" };
            IList<string> expected = new List<string>();
            foreach (var item in sample)
            {
                expected.Add(item);
            }
            IList<string> actual = new List<string>();
            actual = binaryWatch.ReadBinaryWatch(1);
            Assert.AreEqual(true, Enumerable.SequenceEqual(expected.OrderBy(t=>t),actual.OrderBy(t=>t)));
        }
    }
}
