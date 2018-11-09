using System;
using System.Diagnostics;

namespace container_with_most_water
{
    // https://leetcode.com/problems/container-with-most-water/
    class Program
    {
        static void Main(string[] args)
        {
            int[] container = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            // int[] container = new int[] { 8, 2 };

            Stopwatch t = new Stopwatch();
            t.Start();
            int result = MaxArea(container);
            t.Stop();

           Console.WriteLine($"Max volume: {result}. Elapsed time: {t.ElapsedTicks}");
        }

        static int MaxArea(int[] height)
        {
            if ((height == null) || (height.Length == 0))
            {
                return 0;
            }

            if (height.Length == 2)
            {
                return Math.Min(height[0], height[1]);
            }

            int maxVolume = 0;
            int i = 0;
            int j = height.Length - 1;

            while (i < j)
            {
                int tempVolume = Math.Min(height[i], height[j]) * (j - i);
                maxVolume = Math.Max(maxVolume, tempVolume);

                if (height[i] <= height[j])
                    i++;

                else
                    j--;
            }

            return maxVolume;
        }
    }
}
