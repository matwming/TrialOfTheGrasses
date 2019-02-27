using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class AvailableCapturesForRookUnitTest
    {
        public AvailableCapturesForRook AvailableCapturesForRook { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            AvailableCapturesForRook = new AvailableCapturesForRook();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var board = new char[8][];
            board[0] = new char[] {'.','.','.','.','.','.','.','.'};
            board[1] = new char[] {'.','p','p','p','p','p','.','.'};
            board[2] = new char[] {'.','p','p','B','p','p','.','.'};
            board[3] = new char[] {'.','p','B','R','B','p','.','.'};
            board[4] = new char[] {'.','p','p','B','p','p','.','.'};
            board[5] = new char[] {'.','p','p','p','p','p','.','.'};
            board[6] = new char[] {'.','.','.','.','.','.','.','.'};
            board[7] = new char[] {'.','.','.','.','.','.','.','.'};

            var expected = 0;
            var actual = AvailableCapturesForRook.NumRookCaptures(board);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var board = new char[8][];
            board[0] = new char[] {'.','.','.','.','.','.','.','.'};
            board[1] = new char[] {'.','.','.','p','.','.','.','.'};
            board[2] = new char[] {'.','.','.','R','.','.','.','p'};
            board[3] = new char[] {'.','.','.','.','.','.','.','.'};
            board[4] = new char[] {'.','.','.','.','.','.','.','.'};
            board[5] = new char[] {'.','.','.','p','.','.','.','.'};
            board[6] = new char[] {'.','.','.','.','.','.','.','.'};
            board[7] = new char[] {'.','.','.','.','.','.','.','.'};

            var expected = 3;
            var actual = AvailableCapturesForRook.NumRookCaptures(board);
            Assert.AreEqual(expected, actual);
        }
    }
}