public class Program
{

    public static void Main(string[] args)
    {
        var list = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
        // var list = new ListNode(1, new ListNode(2));
        var result = IsPalindrome(list);
        Console.WriteLine(result);
    }

    public static bool IsPalindrome(ListNode head)
    {
        var stack = new Stack<int>();
        var current = head;
        while (current != null)
        {
            stack.Push(current.val);
            current = current.next;
        }

        current = head;
        while (current != null)
        {
            if (current.val != stack.Pop())
            {
                return false;
            }

            current = current.next;
        }

        return true;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

