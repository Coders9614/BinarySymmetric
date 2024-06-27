using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySymmetric
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return IsMirror(root.left, root.right);
        }

        private bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;

            if (left == null || right == null)
                return false;

            if (left.val == right.val)
                return IsMirror(left.left, right.right) && IsMirror(left.right, right.left);

            return false;
        }

        public static void Main()
        {
            // Example is for Symmetric
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);

            Solution solution = new Solution();
            bool isSymmetric = solution.IsSymmetric(root);

            Console.WriteLine(isSymmetric ? "Symmetric" : "Not symmetric");

            
            // Example 1
            TreeNode tree1 = new TreeNode(1);
            tree1.left = new TreeNode(2);
            tree1.right = new TreeNode(2);
            tree1.left.left = new TreeNode(3);
            tree1.left.right = new TreeNode(4);
            tree1.right.left = new TreeNode(4);
            tree1.right.right = new TreeNode(3);

            
            Console.WriteLine($"Example 1- Input: root = [1,2,2,3,4,4,3]: {solution.IsSymmetric(tree1)}"); // Should output true

            // Example 2
            TreeNode tree2 = new TreeNode(1);
            tree2.left = new TreeNode(2);
            tree2.right = new TreeNode(2);
            tree2.left.right = new TreeNode(3);
            tree2.right.right = new TreeNode(3);

            Console.WriteLine($"Example 2 - Input: root = [1,2,2,null,3,null,3]: {solution.IsSymmetric(tree2)}"); // Should output false
            Console.ReadKey();
        }
    }
}
