package questions;

/**
 * Created by user3301 on 8/20/2017.
 * Given two binary trees and imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not.

 You need to merge them into a new binary tree. The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node. Otherwise, the NOT null node will be used as the node of new tree.

 Example 1:
 Input:
 Tree 1                     Tree 2
 1                         2
 / \                       / \
 3   2                     1   3
 /                           \   \
 5                             4   7
 Output:
 Merged tree:
 3
 / \
 4   5
 / \   \
 5   4   7
 */
public class TreeNode {

    private int val;
    private TreeNode left;
    private TreeNode right;

    public TreeNode(int x) {
        this.val = x;
    }

    class solution {

        public TreeNode mergeTrees(TreeNode t1, TreeNode t2) {
            if(t1==null && t2==null) {
                return null;
            }
            int val = (t1==null?0:t1.val) + (t2==null?0:t2.val);
            TreeNode newNode = new TreeNode(val);
            newNode.left = mergeTrees(t1.left==null?null:t1.left, t2.left==null?null:t2.left);
            newNode.right = mergeTrees(t1.right==null?null:t1.right, t2.right==null?null:t2.right);
            return newNode;
        }
    }
}
