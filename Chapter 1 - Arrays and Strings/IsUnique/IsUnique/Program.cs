using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsUnique
{
    /// <summary>
    /// IsUnique
    /// Question: Implement an algorithm to dertermine is a string has all unique characters. What if you cannot use additional data structures?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsUnique("Hello"));
            Console.WriteLine(IsUnique("Slate"));
            Console.WriteLine(IsUniqueNoDS("abcdefghijklmnopqrstuvwxyz1234567890-=!@#$%^&*()_+a"));
            Console.WriteLine(IsUniqueNoDS("Slate"));
            Console.ReadLine();
        }

        static bool IsUnique(string str)
        {
            //O(1)
            if (str.Length > 128)
                return false;

            int val;
            bool[] chars = new bool[128];

            //O(n)
            for (int i = 0; i<str.Length; i++)
            {
                val = str[i];
                if (chars[val])
                {
                    return false;
                } else
                {
                    chars[val] = true;
                }
            }
            return true;
        }

        static bool IsUniqueNoDS(string str)
        {
            //O(1)
            if (str.Length > 128)
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j<str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }


    }
}
