using System.Text;

namespace leetcodesln
{
    public class LongestCommonPrefix
    {
        public string LongestCommonPrefixSln(string[] strs)
        {
            if (strs.Length == 0) return string.Empty;

            var result = new StringBuilder();

            string shortest = strs[0];

            foreach (var str in strs)
            {
                shortest = str.Length < shortest.Length ? str : shortest;
            }

            bool flag = true;

            for (int i = 0; i < shortest.Length && flag; i++)
            {
                var current = shortest[i];
                for (int j = 0; j < strs.Length; j++)
                {
                    if (current != strs[j][i])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) result.Append(current);


            }
            return result.Length == 1 ? (strs.Length == 1 ? strs[0] : result.ToString()) : result.ToString();
        }

        public string LongestCommonPrefixOptimal(string[] strs)
        {
            if(strs.Length == 0) return string.Empty;

            string prefix = strs[0];
            int i = 0;
            while(++i < strs.Length && prefix.Length > 0)
            {
                while(strs[i].IndexOf(prefix)!=0) 
                {
                    prefix = prefix.Substring(0, prefix.Length -1);
                }
            }
            return prefix;
        }
    }
}
