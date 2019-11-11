namespace leetcodesln 
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine) 
        {
            int[] array = new int[26];
            for (int i = 0; i < ransomNote.Length; i++)
            {
                array[magazine[i]-'a']++;
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (--array[ransomNote[i]-'a'] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}