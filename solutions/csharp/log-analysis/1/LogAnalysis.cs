using System.IO.Compression;

public static class LogAnalysis
{

    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delim) => str.Split(delim)[1];

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string leftD, string rightD) =>
    str[(str.IndexOf(leftD)+leftD.Length)..str.IndexOf(rightD)];

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(":").Trim();

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]"); 
}