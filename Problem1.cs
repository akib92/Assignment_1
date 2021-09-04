using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldApp
{
    public class Problem1
    {
        public bool HalvesAreAlike(string s)
        {
            //s.ToLower()
            //0-s.Length/2 and s.Length/2 to s.Length
            HashSet<char> set = new HashSet<char>();
            set.Add('a');
            set.Add('e');
            set.Add('i');
            set.Add('o');
            set.Add('u');
            s = s.ToLower();
            System.Text.StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length / 2; i++)
            {
                sb.Append(s[i]);
            }
            string a = sb.ToString();
            sb.Clear();
            for (int i = s.Length / 2; i < s.Length; i++)
            {
                sb.Append(s[i]);
            }
            string b = sb.ToString();
            int aCount = 0, bCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (set.Contains(a[i]))
                {
                    aCount++;
                }
                if (set.Contains(b[i]))
                {
                    bCount++;
                }
            }
            return aCount == bCount;
        }
    }
}


