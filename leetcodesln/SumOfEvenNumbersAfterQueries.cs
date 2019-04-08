namespace leetcodesln
{
    public class SumOfEvenNumbersAfterQueries
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var res = new int[A.Length];
            var sum = 0;
            var i = 0;
            foreach (var num in A)
            {
                if (num % 2 == 0) sum += num;
            }

            foreach (var query in queries)
            {
                var value = query[0];
                var index = query[1];
                if (A[index] % 2 == 0) sum -= A[index];
                A[index] += value;
                if (A[index] % 2 == 0) sum += A[index];
                res[i++] = sum;
            }
            return res;
        }
    }
}