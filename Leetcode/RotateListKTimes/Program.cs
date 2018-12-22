using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateListKTimes
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Program
    {
        private static ListNode MakeList(int count)
        {
            ListNode head = new ListNode(count);
            ListNode l1 = head;
            while(count != 0)
            {
                l1.next = new ListNode(count--);
                l1 = l1.next;
            }

            return head;
        }

        static void Main(string[] args)
        {
            ListNode l1 = MakeList(4);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            ListNode result = RotateRight(l1, 2000000000);
            watch.Stop();

            Console.WriteLine(result?.val);
            Console.WriteLine(watch.Elapsed);
        }

        public static int FindCount(ListNode head)
        {
            if(head == null)
            {
                return 0;
            }

            int count = 0;
            ListNode temp = head;
            while(temp != null)
            {
                count++;
                temp = temp.next;
            }

            return count;
        }

        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            int count = FindCount(head);
            if (count < k)
            {
                k = k % count;
            }

            while (k != 0)
            {
                Tuple<ListNode, ListNode> temp = SetPointers(head);

                if (temp != null)
                {
                    temp.Item1.next = null;
                    temp.Item2.next = head;
                    head = temp.Item2;
                }

                k--;
            }

            return head;
        }

        private static Tuple<ListNode, ListNode> SetPointers(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode p1 = head;
            ListNode p2 = head.next;

            while (p2 != null && p2.next != null)
            {
                p2 = p2.next;
                p1 = p1.next;
            }

            return new Tuple<ListNode, ListNode>(p1, p2);
        }
    }
}
