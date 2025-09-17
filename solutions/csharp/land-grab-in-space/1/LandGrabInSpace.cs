public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    // TODO: Complete implementation of the Plot struct
    public Coord c1, c2, c3, c4;
    public Plot(Coord c1, Coord c2, Coord c3, Coord c4)
    {
        this.c1 = c1; this.c2 = c2; this.c3 = c3; this.c4 = c4;
    }
}


public class ClaimsHandler
{
    IList<Plot> p = new List<Plot>();
    public void StakeClaim(Plot plot) => p.Add(plot);

    public bool IsClaimStaked(Plot plot) => p.Contains(plot);
    public bool IsLastClaim(Plot plot) => p[^1].Equals(plot);

    public Plot GetClaimWithLongestSide() =>
    p.MaxBy(p => Math.Max(Math.Abs(p.c1.X - p.c2.X), Math.Abs(p.c1.Y - p.c3.Y)));
}
