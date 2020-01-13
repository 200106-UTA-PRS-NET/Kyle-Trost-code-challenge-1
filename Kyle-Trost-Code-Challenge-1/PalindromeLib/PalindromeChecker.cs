using System;

namespace PalindromeLib
{
    public static class PalindromeChecker
    {
        private static bool IsPunctuation(char c)
        {
            return c == ',';
        }

        private static bool IsWhitespace(char c)
        {
            return c == ' ';
        }

        private static string GetCompareString(string str)
        {
            var compare = "";

            foreach(var ch in compare)
            {
                if (!char.IsWhiteSpace(ch) && !char.IsPunctuation(ch))
                    compare += char.ToLower(ch);
            }

            return compare;
        }

        private static string GetReversed(string str)
        {
            var reversed = "";

            for(int x = str.Length - 1; x > -1; x--)
            {
                if(!char.IsWhiteSpace(str[x]) && !char.IsPunctuation(str[x]))
                    reversed += char.ToLower(str[x]);
            }

            Console.WriteLine(reversed);
            return reversed;
        }

        public static bool IsPalindrome(string str)
        {
            var compareStr = GetCompareString(str);

            return compareStr == GetReversed(compareStr);
        }
    }
}
