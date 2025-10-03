using practice.jd.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.LeetCode
{
    public class SubtreeOfAnotherTree
    {
        public bool IsSubtree(TreeNode? root, TreeNode? subRoot)
        {
            if (subRoot == null) return true;
            if (root == null) return false;

            if (IsIdentical(root, subRoot)) return true;

            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);

        }
        private bool IsIdentical(TreeNode? root, TreeNode? subRoot)
        {
            // if both are null then they are identical, shouldn't be null ever on first pass-through due to constraints
            if (root is null && subRoot is null) return true;
            // we need to check that both root and subRoot are not null, otherwise will get NullReferenceException
            if (root != null && subRoot != null && root.val == subRoot.val && IsIdentical(root.left, subRoot.left) && IsIdentical(root.right, subRoot.right)) return true;

            return false;
        }
    }
}
