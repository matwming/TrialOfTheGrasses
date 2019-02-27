using System;

namespace leetcodesln
{
    public class NumberOfSegmentsInAString
    {
        public int CountSegments(string s)
        {
            return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
