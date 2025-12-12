namespace NeetCodeSolution.ProblemSolution.LinkedList._1;

public class Solution0001
{
    public ListNode ReverseList(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while (curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        list.Reverse();

        var dummy = new ListNode(0);
        curr = dummy;

        foreach (var item in list)
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy.next;
    }
}