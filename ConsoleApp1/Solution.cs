//Jimmy Kurian

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        // setting up constraints
        int min = 2;
        int max = 1000000;
        int valleys = 0;
        bool isInValley = false;

        char[] letters = s.ToCharArray();

        if (letters.Length >= min && letters.Length <= max 
            && n >= min && n <= max && n == letters.Length)  {

            List<int> values = new List<int>();
            foreach (var letter in letters)
            {
                if (letter == 'U')
                {
                    values.Add(1);
                }
                else
                {
                    values.Add(-1);
                }
            }

            var path = 0;
            for(int i = 0; i < values.Count; i++)
            {
                path += values[i];   
                if (path < 0 && !isInValley)
                {
                    isInValley = true;
                }

                if (path == 0 && isInValley)
                {
                    valleys++;
                    isInValley = false;
                }
            }
        }

        return valleys;
    }

    static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        Console.Write("Enter first int:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter string:");
        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        Console.WriteLine(result);
        Console.ReadLine();

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
