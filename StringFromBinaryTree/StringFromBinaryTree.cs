using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeChallanges.StringFromBinaryTree
{
    public class StringFromBinaryTree
    {
    public string Tree2str(TreeNode root) {
            if (root == null) {
                return "";
            }

            string result = root.val.ToString();

            if (root.left != null || root.right != null) {
                result += "(" + Tree2str(root.left) + ")";
            }
            
            if (root.right != null) {
                result += "(" + Tree2str(root.right) + ")";
            }

            return result;
        }
    }
}