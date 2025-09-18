using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    private static bool isWindows = OperatingSystem.IsWindows();
    public static string getCultureInfo(Location location) =>
    location switch
    {
        Location.NewYork => "en-US",
        Location.London => "en-GB",
        Location.Paris => "fr-FR",
        _ => "en-GB"
    };

    public static TimeZoneInfo returnTimeZone(Location location)
    {
        string timeZoneId = location switch
        {
            Location.NewYork => isWindows ? "Eastern Standard Time" : "America/New_York",
            Location.London => isWindows ? "GMT Standard Time" : "Europe/London",
            Location.Paris => isWindows ? "W. Europe Standard Time" : "Europe/Paris",
            _ => throw new ArgumentOutOfRangeException()
        };

        return TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

    }

    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        TimeZoneInfo givenTimeZone = returnTimeZone(location);

        DateTime givenTime = DateTime.Parse(appointmentDateDescription);
        return TimeZoneInfo.ConvertTimeToUtc(givenTime, givenTimeZone);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) =>

        alertLevel switch
        {
            AlertLevel.Early => appointment.AddDays(-1),
            AlertLevel.Standard => appointment.Add(new TimeSpan(-1, -45, 0)),
            AlertLevel.Late => appointment.AddMinutes(-30),
            _ => appointment
        };


    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var timeZone = returnTimeZone(location);
        return timeZone.IsDaylightSavingTime(dt) ^ timeZone.IsDaylightSavingTime(dt.AddDays(-7));
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        try
        {
            DateTime givenTime = DateTime.Parse(dtStr, new CultureInfo(getCultureInfo(location)));
            return givenTime;
        }
        catch
        {
            return DateTime.MinValue;
        }
    }
}
