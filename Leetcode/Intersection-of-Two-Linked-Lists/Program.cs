using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection_of_Two_Linked_Lists
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

        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if(headA == null || headB == null)
            {
                return null;
            }

            ListNode result = null;
            int lenA = 0, lenB = 0;
            ListNode tempA = headA;
            ListNode tempB = headB;

            while(tempA != null)
            {
                lenA++;
                tempA = tempA.next;
            }

            while (tempB != null)
            {
                lenB++;
                tempB = tempB.next;
            }

            tempA = headA;
            tempB = headB;
            int diffLen = Math.Abs(lenA - lenB);

            if (diffLen != 0)
            {
                while (diffLen != 0)
                {
                    diffLen--;

                    if (lenA < lenB)
                    {
                        tempB = tempB.next;
                    }
                    else
                    {
                        tempA = tempA.next;
                    }
                }
            }

            while (tempA != null && tempB != null)
            {
                if (tempA == tempB)
                {
                    result = tempA;
                    break;
                }

                tempA = tempA.next;
                tempB = tempB.next;
            }

            return result;
        }
    }
}
