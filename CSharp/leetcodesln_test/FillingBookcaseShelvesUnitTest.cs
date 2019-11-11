using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FillingBookcaseShelvesUnitTest
    {
        public FillingBookcaseShelves FillingBookcaseShelves { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FillingBookcaseShelves = new FillingBookcaseShelves();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var books = new int[7][];
            books[0] = new[] { 1, 1 };
            books[1] = new[] { 2, 3 };
            books[2] = new[] { 2, 3 };
            books[3] = new[] { 1, 1 };
            books[4] = new[] { 1, 1 };
            books[5] = new[] { 1, 1 };
            books[6] = new[] { 1, 2 };
            var shelf_width = 4;
            var expected = 6;
            var actual = FillingBookcaseShelves.MinHeightShelves(books, shelf_width);
            Assert.AreEqual(expected, actual);
        }
    }
}