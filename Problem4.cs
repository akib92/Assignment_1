using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_1
{
	public class Problem4
	{
        public int NumJewelsInStones(string jewels, string stones)
        {
            int ans = 0;
            Dictionary<char, Int16> ht = new Dictionary<char, Int16>();
            foreach (char j in jewels)
            {
                if (!ht.ContainsKey(j))
                    ht.Add(j, 0);
            }

            foreach (char s in stones)
            {
                if (ht.ContainsKey(s))
                {
                    ans++;
                    continue;
                }
            }
            return ans;
        }
    }

}
