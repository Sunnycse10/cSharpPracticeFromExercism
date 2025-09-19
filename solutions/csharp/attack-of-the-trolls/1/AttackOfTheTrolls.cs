// TODO: define the 'AccountType' enum
public enum AccountType{
    Guest,
    User,
    Moderator
}

// TODO: define the 'Permission' enum
[Flags]
public enum Permission
{
    None =  0b00000000,
    Read =  0b00000001,
    Write = 0b00000010,
    Delete= 0b00000100,
    All =   0b00000111,
}


static class Permissions
{
    public static Permission Default(AccountType accountType) =>
    accountType switch
    {
        AccountType.Guest => (Permission)1,
        AccountType.User => (Permission)3,
        AccountType.Moderator => (Permission)7,
        _ => (Permission)0
    };

    public static Permission Grant(Permission current, Permission grant) => current | grant;
    public static Permission Revoke(Permission current, Permission revoke) => (Permission)((int)current- (int)(current&revoke));

    public static bool Check(Permission current, Permission check) => (current & check)==check;
}
