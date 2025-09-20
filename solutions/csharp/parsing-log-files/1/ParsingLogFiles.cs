using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

public class LogParser
{
    public bool IsValidLine(string text) =>
    Regex.IsMatch(text, @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]");

    public string[] SplitLogLine(string text) =>
    Regex.Split(text, @"<[-^*=]+>");

    public int CountQuotedPasswords(string lines) =>
    Regex.Matches(lines, @"""[^""]*password[^""]*""", RegexOptions.IgnoreCase).Count();

    public string RemoveEndOfLineText(string line) =>
    Regex.Replace(line, @"end-of-line\d+", "");

    public string[] ListLinesWithPasswords(string[] lines)
    {
        for (int i = 0; i < lines.Length; i++)
        {
            var match = Regex.Match(lines[i], @"\b(password\w+\b)", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                string word = match.Value;
                lines[i] = $"{word}: {lines[i]}";
            }
            else
            {
                lines[i] = $"--------: {lines[i]}";
            }

        }
        return lines;
    }
}
