using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class ReorderLogFiles
    {
        public string[] ReorderLogFilesSln(string[] logs)
        {
            var letterlist = new List<string>();
            var digitlist = new List<string>();

            foreach (var log in logs)
            {
                if (char.IsNumber(log.Split(' ')[1][0])) digitlist.Add(log);
                else letterlist.Add(log);
            }

            var i = 0;
            while (letterlist.Count != 0)
            {
                logs[i++] = GetMin(ref letterlist);
            }
            foreach (var dig in digitlist)
            {
                logs[i++] = dig;
            }
            return logs;

        }

        private string GetMin(ref List<string> letterlist)
        {
            var min = letterlist.FirstOrDefault();

            foreach (var letteritem in letterlist)
            {

                if (!Comp(min, letteritem))
                {
                    min = letteritem;
                }
            }
            letterlist.Remove(min);
            return min;

        }

        private bool Comp(string max, string newlet)
        {
            var i = 0;
            max = max.Remove(0, max.IndexOf(' ') + 1);
            newlet = newlet.Remove(0, newlet.IndexOf(' ') + 1);

            while (i < max.Length && i < newlet.Length)
            {
                if (max[i] < newlet[i]) return true;
                else if (max[i] > newlet[i]) return false;
                i++;
            }
            return true;
        }
    }
}
