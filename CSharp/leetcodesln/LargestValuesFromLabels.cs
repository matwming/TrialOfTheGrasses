using System.Collections.Generic;

namespace leetcodesln
{
    public class LargestValuesFromLabels
    {
        public int LargestValsFromLabels(int[] values, int[] labels, int num_wanted, int use_limit)
        {
            var ans = 0;
            var labelsOccurrenceTable = new Dictionary<int, int>();  // label, occurrence
            SelectSortValuesAndLabels(ref values, ref labels);

            int idx = 0;
            while (num_wanted != 0)
            {
                if (labelsOccurrenceTable.ContainsKey(labels[idx]) && labelsOccurrenceTable[labels[idx]] < use_limit)
                {
                    ans += values[idx];
                    labelsOccurrenceTable[labels[idx]]++;
                    num_wanted--;
                    idx++;
                }
                else if (!labelsOccurrenceTable.ContainsKey(labels[idx]))
                {
                    ans += values[idx];
                    labelsOccurrenceTable.Add(labels[idx], 1);
                    num_wanted--;
                    idx++;
                }
                else idx++;

                if (idx >= values.Length) break;
            }


            return ans;
        }

        private void SelectSortValuesAndLabels(ref int[] values, ref int[] labels)
        {
            int n = values.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int max_idx = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (values[j] > values[max_idx]) max_idx = j;
                }

                int tempValue = values[max_idx];
                int tempLabel = labels[max_idx];
                values[max_idx] = values[i];
                labels[max_idx] = labels[i];
                values[i] = tempValue;
                labels[i] = tempLabel;
            }
        }
    }
}
