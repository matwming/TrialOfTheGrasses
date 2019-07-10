using System;

namespace leetcodesln
{
    public class CorporateFlightBookings
    {
        public int[] CorpFlightBookings(int[][] bookings, int n)
        {
            throw new NotImplementedException();
        }
    }



    // Segment Tree Implementation
    //    private void buildSegmentTree(int treeIndex, int treeLeft, int treeRight)
    //    {
    //        //如果区间内只剩下一个元素
    //        if (treeLeft == treeRight)
    //        {
    //            tree[treeIndex] = data[treeLeft];
    //            return;
    //        }
    //        //当前节点左子树索引
    //        int leftTreeIndex = getLeft(treeIndex);
    //        //当前节点右子树索引
    //        int rightTreeIndex = getRight(treeIndex);
    //        //int mid = (left+right)/2;
    //        int mid = treeLeft + (treeRight - treeLeft) / 2;
    //        //构建左子树
    //        buildSegmentTree(leftTreeIndex, treeLeft, mid);
    //        //构建右子树
    //        buildSegmentTree(rightTreeIndex, mid + 1, treeRight);
    //        //当前节点存放的值，根据具体业务，如果求和就是两个值相加
    //        //如果是求最大值，那么就存放最大值
    //        tree[treeIndex] = tree[leftTreeIndex] + tree[rightTreeIndex]

}

