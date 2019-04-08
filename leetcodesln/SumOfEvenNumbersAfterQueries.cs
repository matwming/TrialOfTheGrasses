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
                if ((A[query[1]] + query[0]) % 2 == 0)
                {
                    if (A[query[1]] % 2 == 0)
                    {
                        sum = sum + query[0];
                        res[i++] = sum;
                    }
                    else
                    {
                        sum = sum + A[query[1]] + query[0];
                        res[i++] = sum;
                    }
                }
                else
                {
                    if (A[query[1]] % 2 == 0)
                    {
                        sum = sum - A[query[1]];
                        res[i++] = sum;
                    }
                    else
                    {
                        res[i++] = sum;
                    }
                }
                A[query[1]] += query[0];

            }
            return res;
        }
    }
}