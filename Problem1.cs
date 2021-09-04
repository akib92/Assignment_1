using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;


namespace HelloWorldApp
{
	public class Problem1
	{
		public bool halvesAreAlike(string s)
		{
			List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
			Dictionary<char, int> mp = new Dictionary<char, int>();
			foreach (char vowel in vowels)
			{
				mp[vowel] = 1;
			}
			int left = 0;
			int right = s.Length / 2;
			int vowelsLeft = 0;
			int vowelsRight = 0;
			
			while (right < s.Length)
			{
				if (mp[s[left++]] != 0)
				{
					vowelsLeft++;
				}
				if (mp[s[right++]] != 0)
				{
					vowelsRight++;
				}
			}
			return vowelsLeft == vowelsRight;
		}
	}
}


