using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class DistantBarcodes
    {
        public int[] RearrangeBarcodes(int[] barcodes)
        {
            for (int i = 0; i < barcodes.Length; i++)
            {
                if (i - 1 >= 0 && barcodes[i] != barcodes[i - 1] || i - 1 < 0) continue;
                else if(i == barcodes.Length -1)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (barcodes[i] == barcodes[j]) i = j;
                        else if(barcodes[j]!=barcodes[i])
                        {
                            var temp = barcodes[j];
                            barcodes[j] = barcodes[i];
                            barcodes[i] = temp;
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = i+1; j < barcodes.Length; j++)
                    {
                        if(barcodes[j]!= barcodes[i])
                        {
                            var temp = barcodes[j];
                            barcodes[j] = barcodes[i];
                            barcodes[i] = temp;
                            break;
                        }
                    }
                }
            }
            return barcodes;
        }
    }
}
