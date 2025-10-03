using practice.jd.Helpers;

public class MaxDepthBTree
{
    public int MaxDepthRecursiveDFS(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var leftMaxDepth = MaxDepthRecursiveDFS(root?.left);
        var rightMaxDepth = MaxDepthRecursiveDFS(root?.right);

        return 1 + Math.Max(leftMaxDepth, rightMaxDepth);

    }

    public int MaxDepthBFS(TreeNode root)
    {
        var d = 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var levelSize = queue.Count;
            for (var i = 0; i < levelSize; i++)
            {
                TreeNode node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            d++;
        }
        return d;
    }
}