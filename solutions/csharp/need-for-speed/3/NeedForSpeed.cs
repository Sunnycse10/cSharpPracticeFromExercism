class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public int speed{ get; }
    public int batteryDrain{ get; }
    private int _distanceDriven;
    private int _remainingBattery;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        _distanceDriven = 0;
        _remainingBattery = 100;
    }

    public bool BatteryDrained() => _remainingBattery < batteryDrain;

    public int DistanceDriven() => _distanceDriven;
    public void Drive()
    {
        if (!BatteryDrained())
        {
            _distanceDriven += speed;
            _remainingBattery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int _distance;
    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        float drive = (float)100 / (car.batteryDrain);
        float milage = car.speed * drive;
        return milage >= _distance;
    }
}
