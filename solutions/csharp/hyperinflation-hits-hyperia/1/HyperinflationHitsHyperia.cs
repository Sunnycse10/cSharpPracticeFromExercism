public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        string s = "";
        try
        {
            s = checked(@base * multiplier).ToString();
        }
        catch
        {
            s = "*** Too Big ***";
        }
        return s;
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        string s = "";
        float result = @base * multiplier;
        s = float.IsInfinity(result) ? "*** Too Big ***" : result.ToString();
       
        return s;
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
         string s = "";
        try
        {
            s = checked(salaryBase * multiplier).ToString();
        }
        catch
        {
            s = "*** Much Too Big ***";
        }
        return s;
    }
}
