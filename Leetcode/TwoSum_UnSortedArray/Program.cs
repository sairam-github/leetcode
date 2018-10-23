using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum_UnSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/two-sum/solution/

            int[] arr = new int[] { 3, 3 };
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

            // 4 2 3
            // target = 6
            //keyPairs[4] = 0
            //keyPairs[2] = 1
            //keyPairs[3] = 2

            KeyValuePair<int, int> keyPairs = new KeyValuePair<int, int>();
            for (int index = 0; index < nums.Length; index++)
            {
                try
                {
                    keyPairs.Add(nums[index], index);
                }
                catch(ArgumentException ex)
                {
                    throw new Exception("Invalid input array");
                }
            }

            for (int index = 0; index < nums.Length; index++)
            {
                int temp;

                if(keyPairs.TryGetValue(target - nums[index], out temp))
                {
                    if (index == temp)
                        continue;

                    result[0] = index;
                    result[1] = temp;

                    break;
                }
            }

            return result;
        }
    }
}
