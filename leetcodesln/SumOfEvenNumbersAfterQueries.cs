namespace leetcodesln
{
    public class SumOfEvenNumbersAfterQueries
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var result = new int[A.Length];
            
            for (int i = 0; i < queries.Length; i++)
            {
                var sumEven = 0;
                A[queries[i][1]] += queries[i][0];
                foreach (var num in A)
                {
                    if(num % 2 ==0) sumEven += num;
                }
                result[i] = sumEven;
            }

            return result;
        }
    }
}