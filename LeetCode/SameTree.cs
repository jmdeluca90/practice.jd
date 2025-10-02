using practice.jd.Helpers;
public class SameTree
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        // if both are null then return true
        if (p == null && q == null)
        {
            return true;
        }
        // if one is null but not the other, return false
        if (p == null || q == null)
        {
            return false;
        }
        // if values differ, return false
        if (p.val != q.val)
        {
            return false;
        }
        // check left and right trees recursively
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);

    }
}
