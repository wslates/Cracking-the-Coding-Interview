using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPermutation
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool IsPermutation (string str1, string str2)
        {
            //has to be
            if (str1.Length != str2.Length) return false;
            
            //set strings ToLower()
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            //assuming strings are in ascii
            int[] chars = new int[128];

            //count letters using ascii values
            foreach (char c in str1)
            {
                chars[c] += 1;
            }

            //check if 
            foreach (char c in str2)
            {
                chars[c]--;
                if (chars[c] < 0) return false;
            }

            return true;
        }
    }
}
