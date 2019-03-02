using System.Linq;

namespace leetcodesln
{
    public class LargestPerimeterTriangle
    {
        public int LargestPerimeter(int[] A)
        {
            var sortedAscending = (from i in A orderby i ascending select i).ToArray();

            for (int i = A.Length - 1; i > 1; i--)
            {
                if (sortedAscending[i] < sortedAscending[i - 1] + sortedAscending[i - 2]) return sortedAscending[i] + sortedAscending[i - 1] + sortedAscending[i - 2];
            }
            return 0;
        }
    }
}
