using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)=>
        statement switch{
                _ when Regex.IsMatch(statement, @"^(?=.*[A-Z])[A-Z0-9\s\W]+\?$") => "Calm down, I know what I'm doing!" ,
                _ when Regex.IsMatch(statement, @"^(?=.*[A-Z])[A-Z0-9\s\W]+$") => "Whoa, chill out!" ,
                _ when Regex.IsMatch(statement, @"\?\s*$") => "Sure.",
                _ when Regex.IsMatch(statement, @"^\s*$") => "Fine. Be that way!" ,
                _=>"Whatever."                
                
        };
}