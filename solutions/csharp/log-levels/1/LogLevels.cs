static class LogLine
{
    public static string Message(string logLine) =>
    logLine.Split(':')[1].Trim();

    public static string LogLevel(string logLine) =>
    logLine.Split(':')[0].Trim(' ', '[', ']').ToLower();

    public static string Reformat(string logLine)
    {
        string[] arr = logLine.Split(':');
        string s = arr[1].Trim();
        string t = arr[0].Trim(' ', '[', ']').ToLower();
        return $"{s} ({t})";
    }
    
}
