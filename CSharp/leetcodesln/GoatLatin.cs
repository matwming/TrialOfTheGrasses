using System.Linq;
public class GoatLatin
{
    public string ToGoatLatin(string S)
    {
        string[] words = S.Split(' ');
        char[] vowels = {'a', 'e', 'i', 'o', 'u'};
        for (int i = 0; i < words.Length; i++)
        {
            if (vowels.Contains(words[i].ToLower()[0]))
            {
                words[i] += "ma";
                for (int j = 0; j <= i; j++)
                {
                    words[i] += "a";
                }
            }
            else
            {
                words[i] = string.Format($"{words[i].Substring(1, words[i].Length -1)}{words[i][0]}");
                words[i] += "ma";
                for (int j = 0; j <= i; j++)
                {
                    words[i] += "a";
                }
            }
        }
        return string.Join(" ", words);
    }
}