using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_1
{
	public class Problem6
	{
		public List<int> createTargetArray(List<int> nums, List<int> index)
		{
			int n = nums.Count;
			List<int> ans = new List<int>();
			for (int i = 0; i < n; i++)
			{
				//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL vector 'insert' method in C#:
				ans.insert(ans.GetEnumerator() + index[i], nums[i]);
			}
			return new List<int>(ans);
		}
	}

}


}
