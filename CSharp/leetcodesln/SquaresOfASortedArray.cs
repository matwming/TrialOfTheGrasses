namespace leetcodesln
{
    public class SquaresOfASortedArray
    {
        /// <summary>
        /// Since the input array is sorted in non-decreasing order, the most intutive way is to create an array of the squares of each element and sort them
        /// This solution is using two pointer with O(N) complexity
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] SortedSquares(int[] A)
        {
            var front = 0;
            var rear = A.Length - 1;
            var result = new int[A.Length];
            var n = A.Length - 1;

            while (front <= rear)
            {
                if (A[front] * A[front] > A[rear] * A[rear])
                {
                    result[n--] = A[front] * A[front];
                    front++;
                }
                else
                {
                    result[n--] = A[rear] * A[rear];
                    rear--;
                }
            }
            return result;
        }
    }
}
