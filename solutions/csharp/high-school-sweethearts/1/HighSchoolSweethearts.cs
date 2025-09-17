using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB)
    {
        string s = $"{studentA} ♡ {studentB}";
        int leftPadding = 30 - studentA.Length - 1;
        int rightPadding = 30 - studentB.Length - 1;
        return $"{new string(' ', leftPadding)}{s}{new string(' ', rightPadding)}";
    }

    public static string DisplayBanner(string studentA, string studentB)
    {
        string s =
        @"
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**                         **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
";

        int mid = s.Length / 2;
        string name = $"{studentA} +  {studentB}";
        string left = s.Substring(0, mid - 19 - studentA.Length) + name + s.Substring(mid - 25 + name.Length);
        return left;




    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
        string date = start.ToString("dd.MM.yyyy");
        string time = hours.ToString("N2", new CultureInfo("de-DE"));
        return string.Format("{0} and {1} have been dating since {2} - that's {3} hours",studentA,studentB,date,time);
    }
}
