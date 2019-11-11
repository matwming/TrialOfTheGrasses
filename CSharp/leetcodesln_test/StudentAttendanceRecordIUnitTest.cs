using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class StudentAttendanceRecordIUnitTest
    {
        [TestMethod]
        public void StudentAttendanceRecordITestMethod()
        {
            var studentAttendanceRecordI = new StudentAttendanceRecordI();
            var input1 = "PPALLP";
            var expected1 = true;
            var actual1 = studentAttendanceRecordI.CheckRecord(input1);
            Assert.AreEqual(expected1, actual1);

            var input2 = "PPALLL";
            var expected2 = false;
            var actual2 = studentAttendanceRecordI.CheckRecord(input2);
            Assert.AreEqual(expected2, actual2);

            var input3 = "LALL";
            var expected3 = true;
            var actual3 = studentAttendanceRecordI.CheckRecord(input3);
            Assert.AreEqual(expected3, actual3);
        }
    }
}