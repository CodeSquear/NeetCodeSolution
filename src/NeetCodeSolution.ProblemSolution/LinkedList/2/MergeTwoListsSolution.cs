using NeetCodeSolution.ProblemSolution.LinkedList._1;

namespace NeetCodeSolution.ProblemSolution.LinkedList._2;

public class MergeTwoListsSolution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummy = new ListNode(0);
        var curr = dummy;
        foreach (var item in
                 ContcatTwoList(GetConverterListNode(list1), GetConverterListNode(list2)))
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy.next;
    }
    private static List<int> ContcatTwoList(List<int> l1, List<int> l2)
    {
        var list = new List<int>(l1);
        list.AddRange(l2);
        list.Sort();
        return list;
    }

    private static List<int> GetConverterListNode(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while (curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        return list;
    }
}