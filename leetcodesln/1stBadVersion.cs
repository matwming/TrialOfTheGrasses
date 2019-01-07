using System.Collections.Generic;

namespace leetcodesln
{
    public class VersionControl
    {
        public Dictionary<int, bool> VersionStatus { get; set; } = new Dictionary<int, bool>();
        public VersionControl(int n, int firstBadVersion)
        {
            for (int i = 1; i < firstBadVersion; i++)
            {
                VersionStatus.Add(i, false);
            }
            for (int i = firstBadVersion; i <= n; i++)
            {
                VersionStatus.Add(i, true);
            }
        }

        public bool IsBadVersion(int n)
        {
            return VersionStatus[n];
        }
    }
    public class _1stBadVersion : VersionControl
    {
        public _1stBadVersion(int n, int firstBadVersion) : base(n, firstBadVersion)
        {
        }

        public int FirstBadVersion(int n)
        {
            if (IsBadVersion(1)) return 1;

            var L = 1;
            var R = n;
            while (L < R)
            {
                var m = L / 2 + R / 2;
                if (IsBadVersion(m)) R = m;
                else L = m + 1;
            }
            return R;
        }
    }
}
