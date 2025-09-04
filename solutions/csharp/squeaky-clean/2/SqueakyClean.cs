using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static bool isGreekLetter(char c) {
        if (c >= 'α' && c <= 'ω')
        {
            return true;
        }
        return false; 
    }
    public static string Clean(string identifier)
    {
        StringBuilder res = new StringBuilder();
        bool isAfterDash = false;
        foreach (var c in identifier)
        {
            res.Append(c switch
            {
                _ when isGreekLetter(c) => default,
                _ when char.IsWhiteSpace(c) => "_",
                _ when char.IsControl(c) => "CTRL",
                _ when isAfterDash => char.ToUpper(c),
                _ when char.IsLetter(c) => c,
                _ => default
            });
            isAfterDash = c.Equals('-');
        }

        return res.ToString();

    }
}
