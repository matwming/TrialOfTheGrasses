using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LongPressedNameUnitTest
    {
        [TestMethod]
        public void LongPressedNameTestMethod()
        {
            var longPressedName = new LongPressedName();
            var input_name1 = "alex";
            var input_typed1 = "aaleex";
            var expected1 = true;
            var actual1 = longPressedName.IsLongPressedName(input_name1, input_typed1);
            Assert.AreEqual(expected1, actual1);

            var input_name2 = "saeed";
            var input_typed2 = "ssaaedd";
            var expected2 = false;
            var actual2 = longPressedName.IsLongPressedName(input_name2, input_typed2);
            Assert.AreEqual(expected2, actual2);

            var input_name3 = "laiden";
            var input_typed3 = "laiden";
            var expected3 = true;
            var actual3 = longPressedName.IsLongPressedName(input_name3, input_typed3);
            Assert.AreEqual(expected3, actual3);

            var input_name4 = "leelee";
            var input_typed4 = "lleeelee";
            var expected4 = true;
            var actual4 = longPressedName.IsLongPressedName(input_name4, input_typed4);
            Assert.AreEqual(expected4, actual4);

            var input_name5 = "pyplrz";
            var input_typed5 = "ppyypllr";
            var expected5 = false;
            var actual5 = longPressedName.IsLongPressedName(input_name5, input_typed5);
            Assert.AreEqual(expected5, actual5);

            var input_name6 = "vtkgn";
            var input_typed6 = "vttkgnn";
            var expected6 = true;
            var actual6 = longPressedName.IsLongPressedName(input_name6, input_typed6);
            Assert.AreEqual(expected6, actual6);
        }
    }
}