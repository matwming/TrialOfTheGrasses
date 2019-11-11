using System;
public class LicenseKeyFormatting
{
    public string LicenseKeyFormattingSln(string S, int K)
    {
        var cleanStr = S.Replace("-", string.Empty);
        char[] strarr = new char[(cleanStr.Length-1) / K + cleanStr.Length];
        var i = cleanStr.Length -1;
        var arrPtr = strarr.Length -1;
        while (i >=0)
        {
            int count = 1;
            while (count <= K && i >=0)
            {
                strarr[arrPtr--] = char.ToUpper(cleanStr[i--]);
                count++;
            }
            if(i >= 0) strarr[arrPtr--] = '-';
        }
        return new string(strarr);
    }
}
