using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Scriban.Functions;

namespace Assignment_1
{
    public class Problem5
    {
        public string RestoreString(string s, int[] indices)
        {
            char[] charArr = new char[indices.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                charArr[indices[i]] = s[i];
            }
            return new string(charArr);
        }
    }

}
