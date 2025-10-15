public class Matrix
{
    private List<List<int>> list= new();
    public Matrix(string input)
    {
        ToArray(input);
    }

    public int[] Row(int row) => list[row - 1].ToArray();

    public int[] Column(int col)
    {
        List<int> values = new();
        foreach (var rows in list)
        {
            values.Add(rows[col - 1]);
        }
        return values.ToArray();
    }

    private void ToArray(string input)
    {
        string[] temp = input.Split("\n");
        if (temp.Length > 0)
        {
            foreach (string val in temp)
            {
                string[] element = val.Split(' ');
                if (element.Length > 0)
                {
                    List<int> rows = new();
                    foreach (var i in element)
                    {
                        rows.Add(int.Parse(i));
                    }
                    list.Add(rows);
                }
            }
        }
    }


}