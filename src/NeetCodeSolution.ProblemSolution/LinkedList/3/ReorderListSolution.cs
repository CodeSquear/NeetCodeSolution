namespace NeetCodeSolution.ProblemSolution.LinkedList._3;

public class ReorderListSolution
{
    public void ReorderList(ListNode head)
    {
        var reorderList = GetReorderFunc(head);
        var curr = head;
        var index = 0;
        while (curr != null)
        {
            curr.val = reorderList[index];
            curr = curr.next;
            index++;
        }
    }

    private static List<int> GetReorderFunc(ListNode head)
    {
        var list1 = GetListConverter(head)
            .OrderBy(x => x).ToList();
        var list2 = GetListConverter(head)
            .OrderByDescending(x => x).ToList();

        var result = new List<int>();

        for (int i = 0; i < Math.Max(list1.Count, list2.Count); i++)
        {
            if (list1.Count > i)
                result.Add(list1[i]);

            if (list2.Count > i)
                result.Add(list2[i]);
        }

        return result;
    }

    private static List<int> GetListConverter(ListNode head)
    {
        var curr = head;
        var list = new List<int>();

        while (curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        return list;
    }
}