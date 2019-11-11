using System;

namespace leetcodesln
{
    public class SumOfEvenNumbersAfterQueries
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var ans = new int[A.Length];

            var sum = 0;
            Array.ForEach(A, a =>
            {
                if (a % 2 == 0) sum += a;
            });

            for (int i = 0; i < queries.Length; ++i)
            {
                var x = queries[i][0];
                var y = queries[i][1];

                if ((A[y] + x) % 2 != 0)
                {

                    if (A[y] % 2 == 0) sum -= A[y];
                    ans[i] = sum;
                }
                else
                {
                    if (A[y] % 2 == 0)
                    {
                        ans[i] = sum + x;
                        sum += x;
                    }
                    else
                    {
                        sum = sum + A[y] + x;
                        ans[i] = sum;
                    }

                }
                A[y] = A[y] + x;

            }
            return ans;
        }




        public int[] SumEvenAfterQueriesOptimal(int[] A, int[][] queries)
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
