using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class SubdomainVisitCount
    {
        public List<string> SubdomainVisits(string[] cpdomains)
        {
            List<string> result = new List<string>();
            Dictionary<string, int> resultMap = new Dictionary<string, int>();
            foreach (var domainVisit in cpdomains)
            {
                string[] subdomains = ParseSubdomains(domainVisit, out int count);
                foreach (var subdomain in subdomains)
                {
                    if (resultMap.ContainsKey(subdomain))
                    {
                        resultMap[subdomain] += count;
                    }
                    else
                    {
                        resultMap.Add(subdomain, count);
                    }
                }
            }
            foreach (KeyValuePair<string, int> item in resultMap)
            {
                result.Add(item.Value + " " + item.Key);
            }

            return result;
            
        }

        private string[] ParseSubdomains(string input, out int count)
        {
            List<string> resultList = new List<string>();
            int spacePosition = input.IndexOf(' ');
            count = Int32.Parse(input.Substring(0, spacePosition));
            var subdomain = input.Substring(spacePosition+1, input.Length - spacePosition-1);
            while (subdomain.IndexOf('.') != -1)
            {
                resultList.Add(subdomain);
                subdomain = subdomain.Substring(subdomain.IndexOf('.') +1, subdomain.Length - subdomain.IndexOf('.') -1);
            }
            resultList.Add(subdomain);
            string[] result = new string[resultList.Count];
            resultList.CopyTo(result);

            return result;
        }
    }
}
