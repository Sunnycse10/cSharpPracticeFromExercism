using System.Collections;

public static class FlattenArray
{



    public static IEnumerable Flatten(IEnumerable input)
    {
        foreach (var item in input)
        {
            if (item != null)
            {
                if (item is IEnumerable array)
                {
                    foreach (var flattenElement in Flatten(array))
                    {
                        yield return flattenElement;
                    }
                }
                else
                    yield return item;
            }
        }
    }
}