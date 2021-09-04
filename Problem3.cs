using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Problem3
    {
		public int MaximumWealth(int[][] accounts)
		{
			int i, j, sum;
			int max = 0;

			for (i = 0; i < accounts.GetLength(0); i++)
			{
				sum = 0;

				for (j = 0; j < accounts[i].Length; j++)
					sum += accounts[i][j];

				if (sum >= max)
					max = sum;
			}

			return max;
		}
	}

}

