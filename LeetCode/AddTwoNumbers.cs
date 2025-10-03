using practice.jd.Helpers;


public class AddTwoNumbers
{
    public ListNode? AddTwoNumbersSolution(ListNode? l1, ListNode? l2)
    {
        var dummyList = new ListNode(0);
        var tail = dummyList;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int x = l1?.val ?? 0;
            int y = l2?.val ?? 0;

            int sum = x + y + carry;
            int digit = sum % 10;
            carry = sum / 10;

            tail.next = new ListNode(digit);
            tail = tail.next;

            if (l1 != null) l1 = l1?.next;
            if (l2 != null) l2 = l2?.next;
        }
        return dummyList.next;
    }
}
