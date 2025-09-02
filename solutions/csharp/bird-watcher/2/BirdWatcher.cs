class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    } 

    public int Today()
    {
        return this.birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Any(x => x == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        while (--numberOfDays >= 0)
        {
            count += birdsPerDay[numberOfDays];
        }
        return count;
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(x => x >= 5);
    }
}
