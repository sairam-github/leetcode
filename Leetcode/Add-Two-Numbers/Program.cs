using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Two_Numbers
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
        static void Main(string[] args)
        {
            //342 + 465
            // 2 4 3
            // 5 6 4
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null)
            {
                return null;
            }

            ListNode temp1 = l1;
            ListNode temp2 = l2;
            ListNode result = null;
            ListNode tempRunner = null;
            int remainder = 0, quotient = 0;

            while (temp1 != null || temp2 != null)
            {
                int val1 = 0;
                int val2 = 0;

                if (temp1 != null)
                {
                    val1 = temp1.val;
                }

                if (temp2 != null)
                {
                    val2 = temp2.val;
                }

                remainder = (quotient + val1 + val2) % 10;
                quotient = (quotient + val1 + val2) / 10;

                ListNode node = new ListNode(remainder);

                if (tempRunner == null)
                {
                    tempRunner = node;
                    result = tempRunner;
                }
                else
                {
                    tempRunner.next = node;
                    tempRunner = tempRunner.next;
                }

                if (temp1 != null)
                {
                    temp1 = temp1.next;
                }

                if (temp2 != null)
                {
                    temp2 = temp2.next;
                }
            }

            if (quotient != 0)
            {
                ListNode node = new ListNode(quotient);
                tempRunner.next = node;
            }

            return result;
        }
    }
}
