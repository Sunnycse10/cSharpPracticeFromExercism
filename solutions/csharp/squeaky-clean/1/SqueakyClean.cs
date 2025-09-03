using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder res = new StringBuilder();
        for (int i = 0; i < identifier.Length; i++)
        {
            if (identifier[i] == ' ')
            {
                res.Append('_');
            }
            else if (char.IsControl(identifier[i]))
            {
                res.Append("CTRL");
            }
            else if (identifier[i] == '-' && i + 1 < identifier.Length && char.IsLower(identifier[i + 1]))
            {
                res.Append(char.ToUpper(identifier[i + 1]));
                ++i;
            }
            else if (!char.IsLetter(identifier[i]))
            {
                continue;
            }
            else if (identifier[i] >= '\u03B1' && identifier[i] <= '\u03C9')
            {
                continue;
            }
            else
            {
                res.Append(identifier[i]);
            }
        }
        return res.ToString();

    }
}
