using System;
public class LicenseKeyFormatting
{
    public string LicenseKeyFormattingSln(string S, int K)
    {
        var cleanStr = S.Replace("-", string.Empty);
        char[] strarr = new char[(cleanStr.Length-1) / K + cleanStr.Length];
        var cleanStrEndPtr = strarr.Length-1;
        var i = cleanStr.Length -1;
        while(i>=0)
        {
            int counter = 0;
            while (counter <= K-1)
            {
                strarr[cleanStrEndPtr] = char.ToUpper(cleanStr[i - counter]);
                counter++;
                cleanStrEndPtr--;
            }
            i = i - counter;
            if(i < 0) break;
            strarr[cleanStrEndPtr] = '-';
            cleanStrEndPtr--;
        }
        return new string(strarr);
    }
}
