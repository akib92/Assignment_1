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
		public bool CheckIfPangram(string sentence)
		{
			if (sentence.Length < 26) return false;

			Dictionary<char, bool> dic = new Dictionary<char, bool>();

			for (int i = 0; i < sentence.Length; i++)
			{
				if (!dic.ContainsKey(sentence[i]))
					dic.Add(sentence[i], true);

				if (dic.Count == 26) return true;
			}

			return false;
		}
	}

}
