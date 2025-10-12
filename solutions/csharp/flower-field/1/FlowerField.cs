using System.Text;

public static class FlowerField
{
    public static string[] Annotate(string[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            
            var sb = new StringBuilder(input[i]);
            for (int j = 0; j < input[i].Length; j++)
            {
                int count = 0;
                if (input[i][j] != '*')
                {

                    count += ToInt(i > 0 && input[i - 1][j] == '*') +
                                ToInt(j > 0 && input[i][j - 1] == '*') +
                                ToInt(i > 0 && j < input[i].Length - 1 && input[i - 1][j + 1] == '*') +
                                ToInt(i > 0 && j > 0 && input[i - 1][j - 1] == '*') +
                                ToInt(i < input.Length - 1 && input[i + 1][j] == '*') +
                                ToInt(j < input[i].Length - 1 && input[i][j + 1] == '*') +
                                ToInt(i < input.Length - 1 && j < input[i].Length - 1 && input[i + 1][j + 1] == '*') +
                                ToInt(i < input.Length - 1 && j > 0 && input[i + 1][j - 1] == '*');
                    if(count>0)
                    sb[j] = count.ToString()[0];

                }
            }
            input[i] = sb.ToString();
        }
        return input;
    }
    
    public static int ToInt(bool expresstion)
    {
        return Convert.ToInt32(expresstion);
    }
}
