abstract class Character
{
    protected string characterType;

    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString()
    {
        return $"Character is a {this.GetType().Name}";
    }

}

class Warrior : Character
{
    public Warrior() : base("TODO")
    {    
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    private bool _isVulnerable=true;
    public Wizard() : base("TODO")
    {        
    }

    public override bool Vulnerable() => _isVulnerable;

    public override int DamagePoints(Character target) => _isVulnerable ? 3 : 12;

    public void PrepareSpell()=> _isVulnerable = false;
    
}
