namespace leetcodesln
{
    public class FindSmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            //foreach (var letter in letters)
            //{
            //    if (letter-target>0)
            //    {
            //        return letter;
            //    }
            //}
            //return letters[0];
            int length = letters.Length;
            int low = 0;
            int high = length;

            while (low<high)
            {
                int mid = low + (high - low) / 2;
                if (letters[mid]>target)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return letters[low % length];
        }
    }
}
