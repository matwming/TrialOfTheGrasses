using System.Collections.Generic;

namespace leetcodesln
{
    public class ReorderLogFiles
    {
        public string[] ReorderLogFilesSln(string[] logs)
        {
            string[] result = new string[logs.Length];

            var letterLogsList = new List<string>();
            var digitLogsList = new List<string>();

            foreach (var log in logs)
            {
                if (char.IsNumber(log.Split(' ')[1][0])) digitLogsList.Add(log);
                else letterLogsList.Add(log);
            }

            string[] letterArray = letterLogsList.ToArray();

            BubbleSortLetterLogs(ref letterArray);
            for (int i = 0; i < letterArray.Length; i++)
            {
                result[i] = letterArray[i];
            }

            var list_ptr = 0;
            for (int i = letterArray.Length; i < result.Length; i++)
            {
                result[i] = digitLogsList[list_ptr++];
            }
            return result;
        }

        private void BubbleSortLetterLogs(ref string[] letterArray)
        {
            for (int i = 0; i < letterArray.Length - 1; i++)
            {
                for (int j = 0; j < letterArray.Length - 1 - i; j++)
                {
                    if (Comp(letterArray[j], letterArray[j + 1]))
                    {
                        var temp = letterArray[j + 1];
                        letterArray[j + 1] = letterArray[j];
                        letterArray[j] = temp;
                    }
                }
            }
        }

        private bool Comp(string v1, string v2)
        {
            string[] v1s = v1.Split(' ');
            string[] v2s = v2.Split(' ');

            var i = 1;
            while (i < v1s.Length && i < v2s.Length)
            {
                for (int j = 0; j < v1s[i].Length && i < v2s[i].Length; j++)
                {
                    if (v1s[i][j] > v2s[i][j]) return true;
                    else return false;
                }
            }
            return false;
        }
    }
}
