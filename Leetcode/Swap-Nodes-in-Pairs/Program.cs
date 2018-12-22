using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Nodes_in_Pairs
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        static void Main(string[] args)
        {

        }

        static ListNode SwapNodes_ModifyValues(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            ListNode p1 = head, p2 = head.next;

            while (p1 != null && p2 != null)
            {
                int temp = p1.val;
                p1.val = p2.val;
                p2.val = temp;

                p1 = p2.next;

                if (p1 != null)
                {
                    p2 = p1.next;
                }
            }

            return head;
        }

        static ListNode SwapNodes_DoNotModifyValues(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode l1 = head, l2 = head.next, t = null;
            head = head.next;

            while (l1 != null && l2 != null)
            {
                t = l2.next;
                l2.next = l1;
                l1.next = t;

                if (t == null || t.next == null)
                {
                    break;
                }

                ListNode temp = l1;

                l1 = t;
                l2 = t.next;

                temp.next = l2;
            }

            return head;
        }
    }
}
