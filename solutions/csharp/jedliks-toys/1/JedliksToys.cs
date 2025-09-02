class RemoteControlCar
{
    private int _distance=0, _batteryCharge= 100;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distance} meters";

    public string BatteryDisplay() => _batteryCharge==0? "Battery empty": $"Battery at {_batteryCharge}%";

    public void Drive()
    {
        if (_batteryCharge > 0)
        {
            _distance += 20;
            _batteryCharge -= 1;
        }
    }
}
