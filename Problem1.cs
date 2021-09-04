using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;


namespace HelloWorldApp
{
    class Problem1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1 : Enter the string:");
            string s = Console.ReadLine();
            var first = s.Substring(0, (int)(s.Length / 2));
            var last = s.Substring((int)(s.Length/2), (int)(s.Length/2));
            Debug.WriteLine(first);
        }
    }
}