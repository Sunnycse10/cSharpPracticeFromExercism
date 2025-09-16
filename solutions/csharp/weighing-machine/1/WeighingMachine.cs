class WeighingMachine
{
    // TODO: define the 'Precision' property
    public int Precision { get; private set; }

    public WeighingMachine(int precision)
    {
        this.Precision = precision;
    }

    // TODO: define the 'Weight' property
    private double _weight;
    public double Weight
    {
        get => _weight;
        set
        {
            if (value >= 0) _weight = value;
            else throw new ArgumentOutOfRangeException();
        }
    }

    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        get
        {
            float rounded = (float)Math.Round(_weight - TareAdjustment, Precision);

            return $"{rounded.ToString($"F{Precision}")} kg";
        }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5;
}
