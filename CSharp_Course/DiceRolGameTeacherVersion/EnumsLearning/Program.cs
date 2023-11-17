Season firstSeason = Season.Spring;
int firstSeasonAsNumber = (int)firstSeason;

Season summer = Season.Summer;
int summerNumber = (int)summer;

Console.WriteLine($"The number of {firstSeason} is {firstSeasonAsNumber}");
Console.WriteLine($"The number of {summer} is {summerNumber}");

Console.ReadKey();

public enum Season
{
    Spring,
    Summer = 456,
    Autumn,
    Winter
}