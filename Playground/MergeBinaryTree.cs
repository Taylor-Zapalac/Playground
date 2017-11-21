using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    /// <summary>
    /// Given 2 Binary trees, of custom type defined in this class <c>TreeNode</c>
    /// Merge the two;
    /// </summary>
    class MergeBinaryTree
    {
        public void run()
        {
            TreeNode one = new TreeNode(1);
            one.left = new TreeNode(3);
            one.left.left = new TreeNode(5);
            one.right = new TreeNode(2);

            TreeNode two = new TreeNode(2);
            two.left = new TreeNode(1);
            two.left.right = new TreeNode(4);
            two.right = new TreeNode(3);
            two.right.right = new TreeNode(7);

            merge(one, two);
        }
        public TreeNode merge(TreeNode t1, TreeNode t2)
        {
            if (t1 == null) return t2;
            if (t2 == null) return t1;
            
            int val = (t1 == null ? 0 : t1.val) + (t2 == null ? 0 : t2.val);

            TreeNode merged = new TreeNode(val);
            merged.left = merge(t1.left, t2.left);
            merged.right = merge(t1.right,  t2.right);
            
            return merged;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
