namespace leetcodesln
{
    /// <summary>
    /// Amazon online assessment question 2019
    /// </summary>
    public class MoviesOnFlight
    {
        public int[] LongestMovies(int[] movies, int d)
        {
            d = d - 30;
            var longest = 0;
            var ans = new int[] { 0, 0 };
            for (int i = 0; i < movies.Length; i++)
            {
                for (int j = i + 1; j < movies.Length; j++)
                {
                    var cur = movies[i] + movies[j];
                    if (cur <= d)
                    {
                        if (longest >= cur)
                        {
                            continue;
                        }
                        else
                        {
                            longest = cur;
                            ans = new[] { movies[i], movies[j] };

                        }
                    }
                }
            }
            return ans;
        }
    }
}
