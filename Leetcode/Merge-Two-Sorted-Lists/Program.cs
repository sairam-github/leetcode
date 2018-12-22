using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
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

        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            ListNode result = null;
            ListNode t1 = l1, t2 = l2;
            ListNode tempResult = null;

            while (t1 != null && t2 != null)
            {
                int tempVal;

                if (t1.val <= t2.val)
                {
                    tempVal = t1.val;
                    t1 = t1.next;
                }
                else
                {
                    tempVal = t2.val;
                    t2 = t2.next;
                }

                ListNode tempNode = new ListNode(tempVal);

                if (tempResult == null)
                {
                    tempResult = tempNode;
                    result = tempResult;
                }
                else
                {
                    tempResult.next = tempNode;
                    tempResult = tempResult.next;
                }
            }

            if (t1 != null)
            {
                while (t1 != null)
                {
                    ListNode tempNode = new ListNode(t1.val);

                    if (tempResult == null)
                    {
                        tempResult = tempNode;
                        result = tempResult;
                    }
                    else
                    {
                        tempResult.next = tempNode;
                        tempResult = tempResult.next;
                    }

                    t1 = t1.next;
                }
            }

            if (t2 != null)
            {
                while (t2 != null)
                {
                    ListNode tempNode = new ListNode(t2.val);

                    if (tempResult == null)
                    {
                        tempResult = tempNode;
                        result = tempResult;
                    }
                    else
                    {
                        tempResult.next = tempNode;
                        tempResult = tempResult.next;
                    }

                    t2 = t2.next;
                }
            }

            return result;
        }
    }
}
