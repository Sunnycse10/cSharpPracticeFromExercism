public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? ob)
    {
        if (ob is null || ob is not FacialFeatures F) return false;
        if (ReferenceEquals(this, ob)) return true;
        return EyeColor == F.EyeColor && PhiltrumWidth == F.PhiltrumWidth;
    }

    public override int GetHashCode()=>HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? ob)
    {
        if (ob is null || ob is not Identity I) return false;
        else if (ReferenceEquals(this, ob)) return true;
        else return Email == I.Email && FacialFeatures.Equals(I.FacialFeatures);
    }

    public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures.GetHashCode());
}

public class Authenticator
{
    HashSet<Identity> set = new HashSet<Identity>();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity) => identity.Equals(new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m)));

    public bool Register(Identity identity) => set.Add(identity);

    public bool IsRegistered(Identity identity) => set.Contains(identity);
    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
}
