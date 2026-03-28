using System.Globalization;

public enum SublistType
{
    Equal,
    Unequal,
    Superlist,
    Sublist
}

public static class Sublist
{
    public static SublistType Classify<T>(List<T> list1, List<T> list2)
        where T : IComparable
    {
        if (AreEqual(list1, list2)) return SublistType.Equal;
        if (IsSublist(list1, list2)) return SublistType.Superlist;
        if (IsSublist(list2, list1)) return SublistType.Sublist;
        return SublistType.Unequal;

    }

    public static bool AreEqual<T>(List<T> list1, List<T> list2) where T : IComparable
    {
        if (list1.Count != list2.Count) return false;
        if (list1.Count == 0 && list2.Count == 0) return true;
        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i].CompareTo(list2[i]) != 0) return false;
        }
        return true;
    }

    public static bool IsSublist<T>(List<T> list1, List<T> list2) where T : IComparable
    {
        if (list2.Count == 0) return true;
        int i = 0, j = 0;
        int[] arr = BuildLps(list2);
        while (i < list1.Count)
        {
            if (list1[i].CompareTo(list2[j]) == 0)
            {
                i++;
                j++;
                if (j == list2.Count) return true;
            }
            else
            {
                if (j != 0)
                {
                    j = arr[j - 1];
                }
                else
                {
                    i++;
                }
            }
        }
        return false;
    }

    private static int[] BuildLps<T>(List<T> list) where T : IComparable
    {
        int[] arr = new int[list.Count];
        int i = 1, length = 0;
        while (i < list.Count)
        {
            if (list[i].CompareTo(list[length]) == 0)
            {
                arr[i++] = ++length;
            }
            else
            {
                if (length != 0)
                {
                    length = arr[length - 1];
                }
                else
                {
                    arr[i++] = 0;
                }
            }
        }
        return arr;
    }
}