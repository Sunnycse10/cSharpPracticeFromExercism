public static class PalindromeProducts
{

    public static (int, IEnumerable<(int,int)>) Largest(int minFactor, int maxFactor)
    {
        var set = MakeSet(minFactor, maxFactor);
        if (set.Count > 0)
        {
            (int i, int j) = set.Last();
            List<(int, int)> res = [(i, j)];
            int multi = i * j;
            set.Remove(set.Last());
            while (set.Count > 0)
            {
                if (set.Last().Item1 * set.Last().Item2 == multi)
                {
                    res.Add(set.Last());
                    set.Remove(set.Last());
                }
                else
                    break;
            }
            res.Reverse();
            return (i * j, res.ToArray());
        }
        throw new ArgumentException();
    }

    public static (int, IEnumerable<(int, int)>) Smallest(int minFactor, int maxFactor)
    {
        var set = MakeSet(minFactor, maxFactor);
        if (set.Count > 0)
        {
            (int i, int j) = set.First();
            List<(int, int)> res = [(i, j)];
            int multi = i * j;
            set.Remove(set.First());
            while (set.Count > 0)
            {
                if (set.First().Item1 * set.First().Item2 == multi)
                {
                    res.Add(set.First());
                    set.Remove(set.First());
                }
                else
                    break;
            }
            return (i * j, res.ToArray());
        }
        throw new ArgumentException();
    }

    private static SortedSet<(int, int)> MakeSet(int min, int max)
    {
        SortedSet<(int, int)> set = new(
            Comparer<(int, int)>.Create((x, y) =>
            {
                int productX = x.Item1 * x.Item2;
                int productY = y.Item1 * y.Item2;
                int result = productX.CompareTo(productY);
                if (result == 0) result = x.Item1.CompareTo(y.Item1);
                return result; 
            }));
        for (int i = min; i <= max; i++)
        {
            for (int j = i; j <= max; j++)
            {
                if(checkPalinDrome(i,j))
                    set.Add((i, j));
            }

        }
        return set;
    }
    private static bool checkPalinDrome(int i,int j)
    {
        int value = i * j;
        string s = value.ToString();
        return s.SequenceEqual(s.Reverse());
    }
}
