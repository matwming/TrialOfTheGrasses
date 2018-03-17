using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class MinimumAbsoluteDifferenceInBST
    {
        public int GetMinimumDifference(TreeNode root)
        {
            List<int> arr = new List<int>();

            InOrderTraversal(root, ref arr);

            int minimumDifference = Int32.MaxValue;

            for (int i = 0; i < arr.Count-1; i++)
            {
                minimumDifference = minimumDifference > arr[i + 1] - arr[i] ? arr[i + 1] - arr[i] : minimumDifference;
            }
            return minimumDifference;
        }

        private void InOrderTraversal(TreeNode root, ref List<int> arr)
        {
            if (root == null)
            {
                return;
            }
            InOrderTraversal(root.left,ref arr);
            arr.Add(root.val);
            InOrderTraversal(root.right, ref arr);    
        }
    }
}
