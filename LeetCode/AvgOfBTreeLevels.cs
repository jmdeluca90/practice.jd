using practice.jd.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.LeetCode
{
    public class AvgOfBTreeLevels
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> list = new List<double>();
            if (root.left is null && root.right is null)
            {
                list.Add((double)root.val);
                return list;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelCount = queue.Count;
                double sum = 0;

                for (int i = 0; i < levelCount; i++)
                {
                    TreeNode node = queue.Dequeue();
                    sum += (double)node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                double avg = sum / levelCount;
                list.Add(avg);
            }
            return list;
        }
    }
}
