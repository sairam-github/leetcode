using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOnlyLetters
{
    class Program
    {
        // https://leetcode.com/problems/reverse-only-letters/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter input string");
            string S = Console.ReadLine();

            Console.WriteLine(ReverseOnlyLetters(S));
        }

        static string ReverseOnlyLetters(string S)
        {
            if(string.IsNullOrEmpty(S) || S.Length > 100)
            {
                Console.WriteLine("S is not a valid string");
                return S;
            }

            int first = 0;
            int last = S.Length - 1;
            StringBuilder sb = new StringBuilder(S);

            while (first < last)
            {
                if(!((sb[first] >= 'a' && sb[first] <= 'z') || ((sb[first] >= 'A' && sb[first] <= 'Z'))))
                {
                    first++;
                    continue;
                }

                if (!((sb[last] >= 'a' && sb[last] <= 'z') || ((sb[last] >= 'A' && sb[last] <= 'Z'))))
                {
                    last--;
                    continue;
                }
                
                char temp = sb[first];
                sb[first] = sb[last];
                sb[last] = temp;

                first++;
                last--;
            }

            return sb.ToString();
        }
    }
}
