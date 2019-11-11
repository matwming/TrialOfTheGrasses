namespace leetcodesln
{
    public class DeleteColumnsToMakeSorted
    {
        public int MinDeletionSize(string[] A)
        {
            var non_Satified = 0;

            for (int i = 0; i < A[0].Length; i++)
            {
                var j = 0;
                while (j < A.Length - 1)
                {
                    if (A[j][i] > A[j + 1][i])
                    {
                        ++non_Satified;
                        break;
                    }
                    ++j;
                }
            }
            return non_Satified;
        }
    }
}
