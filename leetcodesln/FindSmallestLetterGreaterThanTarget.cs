namespace leetcodesln
{
    public class FindSmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            foreach (var letter in letters)
            {
                if (letter-target>0)
                {
                    return letter;
                }
            }
            return letters[0];
        }
    }
}
