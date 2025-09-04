class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int _speed;
    private int _batteryDrain;
    private int _distanceDriven=0;
    private int _remainingBattery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _remainingBattery < _batteryDrain;

    public int DistanceDriven()
    {
        return _distanceDriven;

    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
             _distanceDriven += _speed;
            _remainingBattery -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
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
        while (car.DistanceDriven() < _distance)
        {
            if (!car.BatteryDrained())
                car.Drive();
            else
                return false;
        }
        return true;
    }
}
