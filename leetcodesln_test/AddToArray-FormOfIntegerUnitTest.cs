using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class AddToArray_FormOfIntegerUnitTest
    {
        public AddToArray_FormOfInteger AddToArray_FormOfInteger { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            AddToArray_FormOfInteger = new AddToArray_FormOfInteger();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var A = new int[] {1,2,0,0};
            var K = 34;
            var expected = new int[] {1,2,3,4};
            var actual = AddToArray_FormOfInteger.AddToArrayForm(A, K);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var A = new int[] {2,7,4};
            var K = 181;
            var expected = new int[] {4,5,5};
            var actual = AddToArray_FormOfInteger.AddToArrayForm(A, K);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var A = new int[] {2,1,5};
            var K = 806;
            var expected = new int[] {1,0,2,1};
            var actual = AddToArray_FormOfInteger.AddToArrayForm(A, K);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var A = new int[] {9,9,9,9,9,9,9,9,9,9};
            var K = 1;
            var expected = new int[] {1,0,0,0,0,0,0,0,0,0,0};
            var actual = AddToArray_FormOfInteger.AddToArrayForm(A, K);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        
    }
}