namespace NeetCodeSolution.ProblemSolution.LinkedList._4;

public class MergeKListsSolution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return null;

        var list = new List<int>();

        foreach (var item in lists)
            GetListConverter(item, list);

        var dummy = new ListNode(0);
        var curr = dummy;

        foreach (var val in list.OrderBy(x => x))
        {
            curr.next = new ListNode(val);
            curr = curr.next;
        }

        return dummy.next;
    }

    private void GetListConverter(ListNode head, List<int> list)
    {
        var curr = head;
        while (curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }
    }
}
