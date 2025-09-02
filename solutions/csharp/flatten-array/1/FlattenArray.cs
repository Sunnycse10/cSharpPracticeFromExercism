using System.Collections;

public static class FlattenArray
{

    public static List<object> Traverse(List<object> values, IEnumerable input)
    {
        foreach (var item in input)
        {
            if (item != null)
            {
                if (item is IEnumerable nested)
                    Traverse(values, nested);
                else
                    values.Add(item);
            }
        }
        return values;
    }


    public static IEnumerable Flatten(IEnumerable input)
    {
        List<object> values = new();
        values = Traverse(values, input);

        return values.ToArray();
    }
}