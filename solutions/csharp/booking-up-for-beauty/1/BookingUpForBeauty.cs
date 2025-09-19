using System.Globalization;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate) => DateTime.Compare(appointmentDate,DateTime.Now)<0;

    public static bool IsAfternoonAppointment(DateTime appointmentDate)=>appointmentDate.Hour is >=12 and <18;

    public static string Description(DateTime appointmentDate) =>
    $"You have an appointment on {appointmentDate.ToString()}.";

    public static DateTime AnniversaryDate() => DateTime.Parse("15/9/2025", new CultureInfo("fr-FR"));

}
