using System;
using System.Collections.Generic;

namespace JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Jewels string");
            string J = Console.ReadLine();

            Console.WriteLine("Enter Stones string");
            string S = Console.ReadLine();

            Console.WriteLine($"Output is: {NumJewelsInStones(J, S)}");
        }

        static int NumJewelsInStones(string J, string S)
        {
            if (string.IsNullOrWhiteSpace(J) || string.IsNullOrWhiteSpace(S))
            {
                Console.WriteLine("Invalid input");
                return 0;
            }

            Dictionary<char, int> Jj = new Dictionary<char, int>();
            foreach (var c in J.ToCharArray())
            {
                Jj.Add(c, 1);
            }

            Dictionary<char, int> Ss = new Dictionary<char, int>();
            foreach (var c in S.ToCharArray())
            {
                int count = 1;
                if (Ss.TryGetValue(c, out count))
                {
                    Ss.Remove(c);
                    count++;
                    Ss.Add(c, count);
                    continue;
                }

                Ss.Add(c, 1);
            }

            int result = 0;
            foreach (var c in Ss.Keys)
            {
                int count = 0;
                if (Jj.TryGetValue(c, out count))
                {
                    result += Ss[c];
                }
            }

            return result;
        }
    }
}
