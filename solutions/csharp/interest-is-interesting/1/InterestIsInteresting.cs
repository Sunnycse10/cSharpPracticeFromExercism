static class SavingsAccount
{
    public static float InterestRate(decimal balance) =>
    balance switch
    {
        < 0m => 3.213f,
        < 1000m => 0.5f,
        >= 1000m and < 5000 => 1.621f,
        >= 5000m => 2.475f

    };

    public static decimal Interest(decimal balance) => (decimal)InterestRate(balance) * balance / 100;

    public static decimal AnnualBalanceUpdate(decimal balance) => Interest(balance) + balance;

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;
        while (balance < targetBalance)
        {
            float interest = InterestRate(balance);
            balance += (decimal)interest * balance / 100;
            year++;
        }
        return year;
    }
}
