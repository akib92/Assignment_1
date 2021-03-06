using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DIS_Assignmnet1_Fall_2021

{

    class Program

    {
        static void Main(string[] args)

        {

            //Question 1 

            Console.WriteLine("Q1 : Enter the string:");

            string s = Console.ReadLine();

            bool pos = HalvesAreAlike(s);

            if (pos)

            {

                Console.WriteLine("Both Halfs of the string are alike");

            }

            else

            {

                Console.WriteLine("Both Halfs of the string are not alike");

            }



            Console.WriteLine();



            //Question 2: 

            Console.WriteLine(" Q2 : Enter the string to check for pangram:");

            string s1 = Console.ReadLine();

            bool flag = CheckIfPangram(s1);

            if (flag)

            {

                Console.WriteLine("Yes, the given string is a pangram");

            }

            else

            {

                Console.WriteLine("No, the given string is not a pangram");

            }

            Console.WriteLine();



            //Question 3: 

            int[,] arr = new int[,] { { 1, 2, 3 }, { 3, 2, 1 } };

            int Wealth = MaximumWealth(arr);

            Console.WriteLine("Q3:");

            Console.WriteLine("Richest person has a wealth of {0}", Wealth);





            //Question 4: 

            string jewels = "aA";

            string stones = "aAAbbbb";

            Console.WriteLine("Q4:");

            int num = NumJewelsInStones(jewels, stones);

            Console.WriteLine("the number of stones you have that are also jewels are {0}:", num);



            Console.WriteLine();



            //Question 5: 

            Console.WriteLine("Q5:");

            String word2 = "aiohn";

            int[] indices = { 3, 1, 4, 2, 0 };

            String rotated_string = RestoreString(word2, indices);

            Console.WriteLine("The Final string after rotation is {0}", rotated_string);





            //Quesiton 6: 

            Console.WriteLine("Q6: Enter the sentence to convert:");

            int[] nums = { 0, 1, 2, 3, 4 };

            int[] index = { 0, 1, 2, 2, 1 };

            int[] target = CreateTargetArray(nums, index);

            Console.WriteLine("Target array  for the Given array's is:");

            for (int i = 0; i < target.Length; i++)

            {

                Console.Write(target[i] + "\t");

            }

            Console.WriteLine();



        }



        /*  

        <summary> 

        You are given a string s of even length. Split this string into two halves of equal lengths, and let a be the first half and b be the second half. 

        Two strings are alike if they have the same number of vowels ('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'). Notice that s contains uppercase and lowercase letters. 

        Return true if a and b are alike. Otherwise, return false 



        Example 1: 

        Input: s = "book" 

        Output: true 

        Explanation: a = "bo" and b = "ok". a has 1 vowel and b has 1 vowel. Therefore, they are alike. 

        </summary> 

        */

        private static bool HalvesAreAlike(string s)

        {

            try
                //Creating a HashSet with the vowels and change input string to lowercase

            {
                HashSet<char> set = new HashSet<char>();
                set.Add('a');
                set.Add('e');
                set.Add('i');
                set.Add('o');
                set.Add('u');
                s = s.ToLower();
                System.Text.StringBuilder sb = new StringBuilder();
                //Diving the input String into two equal parts 
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
                //Counting the number of vowels in each part and compare
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

            catch (Exception)

            {

                throw;

            }



        }



        /*  

 <summary> 

A pangram is a sentence where every letter of the English alphabet appears at least once. 

Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise. 

Example 1: 

Input: sentence = "thequickbrownfoxjumpsoverthelazydog" 

Output: true 

Explanation: sentence contains at least one of every letter of the English alphabet. 

</summary> 

</returns> true/false </returns> 

Note: Use of String function (Contains) and hasmap is not allowed, think of other ways how you could the numbers be represented 

*/

        public static bool CheckIfPangram(string sentence)

        {

            try

            {
                // Checks if sentence has lenght greater then 26 
                if (sentence.Length < 26) return false;

                Dictionary<char, bool> dic = new Dictionary<char, bool>();

                // Checks if sentence have have 26 different characters
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (!dic.ContainsKey(sentence[i]))
                        dic.Add(sentence[i], true);

                    if (dic.Count == 26) return true;
                }

                return false;

            }

            catch (Exception)

            {



                throw;

            }



        }

        /* 

        <summary>  

        You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the ith customer has in the jth bank. Return the wealth that the richest customer has. 

       A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth. 



       Example 1: 

       Input: accounts = [[1,2,3],[3,2,1]] 

       Output: 6 

       Explanation: 

       1st customer has wealth = 1 + 2 + 3 = 6 

       2nd customer has wealth = 3 + 2 + 1 = 6 

       Both customers are considered the richest with a wealth of 6 each, so return 6. 

       </summary> 

        */

        public static  int MaximumWealth(int[,] accounts)

        {

            try

            {
                //creating two integer i & j
                int i, j, sum;
                int max = 0;

                // Getting the lenght of i and j and using sum to calculate total
                for (i = 0; i < accounts.GetLength(0); i++)
                {
                    sum = 0;

                    for (j = 0; j < accounts.GetLength(1); j++)
                        sum += accounts[i,j];

                    // Getting the highest sum
                    if (sum >= max)
                        max = sum;
                }

                return max;
            }

            catch (Exception)

            {

                throw;

            }

        }

        /* 

 <summary> 

You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. 

Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels. 

Letters are case sensitive, so "a" is considered a different type of stone from "A". 

  

Example 1: 

Input: jewels = "aA", stones = "aAAbbbb" 

Output: 3 

Example 2: 

Input: jewels = "z", stones = "ZZ" 

Output: 0 

  

Constraints: 

•	1 <= jewels.length, stones.length <= 50 

•	jewels and stones consist of only English letters. 

•	All the characters of jewels are unique. 

</summary> 

 */

        private static int NumJewelsInStones(string jewels, string stones)

        {

            try

            {

                int ans = 0;
                Dictionary<char, Int16> ht = new Dictionary<char, Int16>();
                // Read the characters in jewels
                foreach (char j in jewels)
                {
                    if (!ht.ContainsKey(j))
                        ht.Add(j, 0);
                }

                // Compares the characters in jewels with stone and sum
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

            catch (Exception e)

            {



                Console.WriteLine("An error occured: " + e.Message);

                throw;

            }



        }







        /* 



        <summary> 

        Given a string s and an integer array indices of the same length. 

        The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string. 

        Return the shuffled string. 



        Example 3: 

        Input: s = "aiohn", indices = [3,1,4,2,0] 

        Output: "nihao" 

        */



        private static string RestoreString(string s, int[] indices)

        {

            try

            {

                
                   // creates an integer i which sorts the strings according to the indices
                    char[] charArr = new char[indices.Length];
                    for (int i = 0; i < indices.Length; i++)
                    {
                        charArr[indices[i]] = s[i];
                    }
                string x = new string(charArr);
                    return x;
                

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

                throw;

            }



        }



        /* 

        <summary> 

Given two arrays of integers nums and index. Your task is to create target array under the following rules: 

•	Initially target array is empty. 

•	From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in target array. 

•	Repeat the previous step until there are no elements to read in nums and index. 

Return the target array. 

It is guaranteed that the insertion operations will be valid. 

  

Example 1: 

Input: nums = [0,1,2,3,4], index = [0,1,2,2,1] 

Output: [0,4,1,3,2] 

 

 

Explanation: 

nums       index     target 

0            0        [0] 

1            1        [0,1] 

2            2        [0,1,2] 

3            2        [0,1,3,2] 

4            1        [0,4,1,3,2] 

*/

        private static int[] CreateTargetArray(int[] nums, int[] index)

        {

            try

            {
                // create new array
                int[] target = new int[nums.Length];

                // sort the array with nums in the target array
                for (int i = 0; i < nums.Length; i++)
                {
                    if (index[i] == i)
                    {
                        target[i] = nums[i];
                    }
                    else
                    {
                        for (int j = i; j > index[i]; j--)
                        {
                            target[j] = target[j - 1];
                        }
                        target[index[i]] = nums[i];

                    }
                }
                return target;

            }

            catch (Exception)

            {



                throw;

            }



        }

    }

}

//Self-Reflection

//It took me about 3-4 hours to complete the whole assignments.
//I am new to the C# language, so learned a lot about the structure, logic and pattern about the language from the assignment. It was a very productive conceptual exercise to me
//I believe that there could be some more basic programing challanges given to us before we were given this assignment. the assignment proved a little bit challanging to me.