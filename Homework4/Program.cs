double[] week = { 14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4 };
static double Average(double[] arr)
{
    double sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}
double average = Average(week);
Console.WriteLine($"Average temperature: {average:F1} " );

int hottestDay = 0;

for (int i = 1; i < week.Length; i++)
{
    if (week[i] > week[hottestDay])
    {
        hottestDay = i;
    }
}
Console.WriteLine("Hottest day: " + (hottestDay + 1));
Console.WriteLine("Temperature: " + week[hottestDay]);

Console.WriteLine("Days above average:");

for (int i = 0; i < week.Length; i++)
{
    if (week[i] > average)
    {
        Console.WriteLine("Day " + (i + 1) + ": " + week[i]);
    }
}

Console.WriteLine("Last three days:");

double[] lastThreeDays = week[^3..];

for (int i = 0; i < lastThreeDays.Length; i++)
{
    Console.WriteLine(lastThreeDays[i]);
}
