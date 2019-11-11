namespace leetcodesln
{
    public class StudentAttendanceRecordI
    {
        public bool CheckRecord(string s)
        {
            var A = 0;
            char previous = 'X';
            char prePrevious = 'X';
            foreach (var chr in s)
            {
                if(chr=='A') A++;
                if((chr=='L' && previous=='L' && prePrevious=='L') || A>1) return false;
                prePrevious = previous;
                previous = chr;
            }
            return true;
        }
    }
}