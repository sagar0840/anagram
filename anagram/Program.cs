using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            {
                ArrayList str1 = new ArrayList();
                str1.Add('L');
                str1.Add('i');
                str1.Add('s');
                str1.Add('t');
                str1.Add('e');
                str1.Add('n');

                ArrayList str2 = new ArrayList();
                str2.Add('s');
                str2.Add('i');
                str2.Add('L');
                str1.Add('e');
                str1.Add('n');
                str1.Add('t');
                if (areAnagram(str1, str2))
                {
                    Console.WriteLine("The two strings are anagram of each other");
                }
                else
                {
                    Console.WriteLine("The two strings are not anagram of each other");
                }
            }
        }
        private static bool areAnagram(ArrayList str1, ArrayList str2)
        {
            int n1 = str1.Count;
            int n2 = str2.Count;
            if (n1 != n2)
            {
                return false;
            }
            str1.Sort();
            str2.Sort();
            for (int i = 0; i < n1; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
