using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.Helpers;
public class ListNode
{
    public int? val;
    public ListNode? next;
    public ListNode? prev;
    public ListNode(int? val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}