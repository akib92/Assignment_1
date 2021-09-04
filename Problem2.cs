using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_1
{
	public class Problem2
	{
		public bool checkIfPangram(string sentence)
		{
			List<int> mp = new List<int>(26);
			foreach (char ch in sentence)
			{
				mp[ch - 'a']++;
			}
			foreach (int num in mp)
			{
				if (num == 0)
				{
					return false;
				}
			}
			return true;
		}
	}

}
