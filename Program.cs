using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isSameTree
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode a = new TreeNode(1);
            a.val = 1; 
            a.left = new TreeNode(1); 
            a.left.left= new TreeNode(1);
            int x =MaxDepth(a);
            Console.WriteLine("X=" + x);
            Console.Read();
            //IsSameTree(a, b);
        }

        static bool IsSameTree(TreeNode p, TreeNode q)
        {
            bool result = false;

            if (p == null || q == null)
            {
                if (p == null && q == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (p.val.Equals(q.val))
            {
                if (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        static int MaxDepth(TreeNode root)
        {
            int result = 0;
            
            if (root.right != null || root.left != null)
            {
                result++;
                if (root.right != null)
                {
                    result += MaxDepth(root.right);
                }
                else if (root.left != null)
                {
                    result += MaxDepth(root.left);
                }
            }

            return result;
        }
    }
}
