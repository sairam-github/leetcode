using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteLinkedList
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

        public static void DeleteList_Recursion(ListNode head)
        {
            if (head == null)
            {
                return;
            }

            DeleteList_Recursion(head.next);

            head.next = null;
        }

        public static void DeleteList_Iterative(ListNode head)
        {
            if (head == null)
            {
                return;
            }

            ListNode temp = head;

            while(head != null)
            {
                head.next = null;
                temp = temp.next;
                head = temp;
            }
        }
    }
}
