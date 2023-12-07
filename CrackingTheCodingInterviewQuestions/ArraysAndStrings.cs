using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackingTheCodingInterviewQuestions
{
    public static class ArraysAndStrings
    {

        public static bool AreAllCharactersUnique(string input)
        {
            HashSet<char> unique = new HashSet<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (unique.Contains(input[i]))
                {
                    return false;
                }
                else
                {
                    unique.Add(input[i]);
                }
            }
            return true;
        }


        public static bool AreAllCharactersUniqueWithOnlyString(string input)
        {
            string uniqueHolder = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (!uniqueHolder.Contains(input[i]))
                {
                    uniqueHolder += input[i];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPermutation(string input1, string input2)
        {
            if (input1.Length != input2.Length)
            {
                return false;
            }
            string input2Temp = input2;
            Dictionary<char, int> unique = new Dictionary<char, int>();
            for (int i = 0; i < input1.Length - 1; i++)
            {
                for (int j = 0; j < input2.Length - 1; j++)
                {
                    if (input2Temp.Count() == 0)
                    {
                        return true;
                    }
                    if (input1[i] == input2[j])
                    {
                        input2Temp = input2Temp.Remove(j);
                        break;
                    }
                }
            }
            return false;
        }

        public static string AddingPercentTwentyToString(String originalString)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in originalString)
            {
                if (c == ' ')
                {
                    stringBuilder.Append("%20");
                }
                else
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString();
        }

        public static bool PalindromePermutation(string input)
        {
            Dictionary<char,int> charCounts = new Dictionary<char,int>();
            for(int i = 0; i < input.Length; i++)
            {
                if (charCounts.ContainsKey(input[i]))
                {
                    charCounts[input[i]]++;
                }
                else
                {
                    charCounts.Add(input[i], 1);
                }
            }
            List<int> valuesList = new List<int>(charCounts.Values);
            int oddCount = 0;

            foreach (int number in valuesList)
            {
                if (number % 2 != 0)
                {
                    oddCount++;
                }
            }
            if(oddCount > 1)
            {
                // is not a palindrome
                return false;
            }
            return true;
        }

        public static bool OneAway(string input1, string input2)
        {
            if (Math.Abs(input1.Length - input2.Length) > 1)
            {
                return false;
            }
            if (input1.Length == input2.Length)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    int mismatches = 0;
                    if (input1[i] != input2[i])
                    {
                        mismatches++;
                    }
                    if (mismatches > 1)
                    {
                        return false;
                    }
                }
                return true;
            }

            if (input1.Length > input2.Length)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    if (input1[i] != input2[i])
                    {
                        string before = input2.Substring(0, i);
                        string after = i < input2.Length ? input2.Substring(i) : "";
                        input2 = before + input1[i] + after;
                        if (input1 == input2)
                        {
                            return true;
                        }
                        return false;
                        //insert whats at input1[i] into input2[i]
                        //check that the 2 inputs are now equal
                    }
                }
            }
            if (input2.Length > input1.Length)
            {
                for (int i = 0; i < input2.Length; i++)
                {
                    // Create a new string excluding the character at index i
                    string withoutChar = input2.Substring(0, i) + (i < input2.Length - 1 ? input2.Substring(i + 1) : "");

                    // Check if this new string equals input1
                    if (input1 == withoutChar)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

    }
}
