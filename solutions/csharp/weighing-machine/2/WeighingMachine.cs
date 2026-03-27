using System.Globalization;

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
            var format = new NumberFormatInfo { NumberDecimalDigits = Precision };
            

            return $"{(this.Weight-this.TareAdjustment).ToString("F",format)} kg";
        }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5;
}
