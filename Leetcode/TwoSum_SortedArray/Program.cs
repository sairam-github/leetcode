using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/two-sum/

            int[] arr = new int[] {3, 2, 4};
            int target = 6;

            int[] result = FindTwoSum(arr, target);
        }

        private static int[] FindTwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            if (nums.Length == 0 || target == 0)
            {
                return result;
            }
            
            int first = 0;
            int last = nums.Length - 1;

            while(first < last)
            {
                if(nums[first] + nums[last] == target)
                {
                    result[0] = first;
                    result[1] = last;

                    break;
                }
                else if (nums[first] + nums[last] < target)
                {
                    first++;                    
                }
                else if (nums[first] + nums[last] > target)
                {
                    last--;
                }
            }

            return result;
        }
    }
}
