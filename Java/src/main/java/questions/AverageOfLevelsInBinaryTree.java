package questions;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

/**
 * Created by user3301 on 9/3/2017.
 */
public class AverageOfLevelsInBinaryTree {

    public List<Double> averageOfLevels(TreeNode root) {
     Queue<TreeNode> nodeQueue = new LinkedList<>();
     List<Double> average = new ArrayList<>();
     if(root==null) {
         return average;
     }
     nodeQueue.offer(root);
     while(!nodeQueue.isEmpty()) {
         int size = nodeQueue.size();
         Double total = 0.0;
         for (int i = 0; i < size; i++) {
             TreeNode currentNode = nodeQueue.poll();
              total += currentNode.val;
              if(currentNode.left!=null) {nodeQueue.offer(currentNode.left);}
              if(currentNode.right!=null) {nodeQueue.offer(currentNode.right);}
         }
         average.add(total/size);
     }
     return average;
    }

    class TreeNode {
        int val;
        TreeNode left;
        TreeNode right;
        TreeNode(int x) {val = x;}
    }
}
