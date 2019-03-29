using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
public class BinarySearchUnitTest
{
    public BinarySearch BinarySearch { get; set; }

    [TestInitialize]
    public void BeforeEach()
    {
        BinarySearch = new BinarySearch();
    }

    [TestMethod, Timeout(5_000)]
    public void TestMethod1()
    {
        var nums = new int[] { -1, 0, 3, 5, 9, 12 };
        var target = 9;
        var expected = 4;
        Assert.AreEqual(expected, BinarySearch.Search(nums, target));
    }

    [TestMethod, Timeout(5_000)]
    public void TestMethod2()
    {
        var nums = new int[] { -1, 0, 3, 5, 9, 12 };
        var target = 2;
        var expected = -1;
        Assert.AreEqual(expected, BinarySearch.Search(nums, target));
    }

    [TestMethod, Timeout(5_000)]
    public void TestMethod3()
    {
        var nums = new int[] { 5 };
        var target = 5;
        var expected = 0;
        Assert.AreEqual(expected, BinarySearch.Search(nums, target));
    }

}