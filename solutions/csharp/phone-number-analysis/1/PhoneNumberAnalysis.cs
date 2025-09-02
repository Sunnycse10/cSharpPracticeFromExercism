public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] array = phoneNumber.Split("-");
        bool IsNewWork = array[0] == "212";
        bool isFake = array[1] == "555";
        return (IsNewWork, isFake, array[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;

    }
}
