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
		public int numJewelsInStones(string J, string S)
		{
			bool[] map = new bool[256];
			foreach (var c in J)
			{
				map[c] = true;
			}
			int cnt = 0;
			foreach (var c in S)
			{
				if (map[c])
				{
					cnt++;
				}
			}
			return cnt;
		}
	}

}
