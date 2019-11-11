using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class UniqueEmailAddresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            List<string> processed = new List<string>();

            foreach (var email in emails)
            {
                var sb = new StringBuilder();
                int localNameIndex = email.IndexOf('@');
                var localName = email.Substring(0, localNameIndex);
                foreach (var character in localName)
                {
                    if(character=='.')
                    {
                        continue;
                    }
                    if(character=='+')
                    {
                        break;
                    }
                    sb.Append(character);
                }
                sb.Append("@").Append(email.Substring(localNameIndex+1));
                if(!processed.Contains(sb.ToString()))
                {
                    processed.Add(sb.ToString());
                }
            }
            return processed.Count;
        }
    }
}