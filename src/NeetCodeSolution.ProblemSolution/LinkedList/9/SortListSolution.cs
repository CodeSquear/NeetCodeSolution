using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeetCodeSolution.ProblemSolution.LinkedList_9;

public class SortListSolution
{
    public ListNode SortList(ListNode head)
    {
        var dummy = new ListNode(0);
        var curr = dummy;

        foreach(var item in ConvertListNodeToList(head))
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy.next;
    }

    private static List<int> ConvertListNodeToList(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while(curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        list.Sort();

        return list;
    }
}
