using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Problem3
    {
        public int maximumWealth(List<vector> accounts)
        {
            // to keep a track of maximum wealth;
            int max_wealth = 0;
            for (int i = 0; i < accounts.Count; i++)
            {
                // take each customer and calculate customer_wealth;
                int customer_wealth = 0;
                for (int j = 0; j < accounts[i].size(); j++)
                {
                    customer_wealth += accounts[i][j];
                }
                // if customer_wealth>max_wealth, make it as max.
                if (customer_wealth > max_wealth)
                {
                    max_wealth = customer_wealth;
                }
            }
            // return max_wealth;
            return max_wealth;
        }
    }

}

