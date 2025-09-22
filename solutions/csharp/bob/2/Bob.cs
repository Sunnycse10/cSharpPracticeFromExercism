using System;
using System.Text.RegularExpressions;

public static class Bob
{
        public static string Response(string statement)
        {
                if (statement.isSilence()) return "Fine. Be that way!";
                if (statement.isYell() && statement.isQuestion()) return "Calm down, I know what I'm doing!";
                if (statement.isYell()) return "Whoa, chill out!";
                if (statement.isQuestion()) return "Sure.";
                return "Whatever.";

        }
        public static bool isSilence(this string str) => string.IsNullOrWhiteSpace(str);
        public static bool isYell(this string str) => str.Any(char.IsLetter) && str.ToUpperInvariant() == str;
        public static bool isQuestion(this string str) => str.TrimEnd().EndsWith('?');
}