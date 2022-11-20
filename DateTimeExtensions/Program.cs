// See https://aka.ms/new-console-template for more information

using DateTimeExtensions;

void RunTests(DateTime dtFrom, DayOfWeek dayOfWeek)
{
    DateTime dtNext = dtFrom.GetDateOfTarget(dayOfWeek);

    Console.WriteLine($"The {dayOfWeek} after {dtFrom.ToString("MM/dd/yyyy")} is {dtNext.ToString("MM/dd/yyyy")}.");
}

var dates = new DateTime[]
{
    // Case 1 - Current date is a Sunday
    new DateTime(2022, 11, 6),

    // Case 2 - Current date is a Wednesday
    new DateTime(2022, 11, 9),

    // Case 3 - Current date is a Saturday
    new DateTime(2022, 11, 12),

    // Case 4 - Current date is a Saturday, in a leap year.
    new DateTime(2016, 2, 27)
};

foreach (var dtFrom in dates)
{
    RunTests(dtFrom, DayOfWeek.Sunday);
    RunTests(dtFrom, DayOfWeek.Monday);
    RunTests(dtFrom, DayOfWeek.Tuesday);
    RunTests(dtFrom, DayOfWeek.Wednesday);
    RunTests(dtFrom, DayOfWeek.Thursday);
    RunTests(dtFrom, DayOfWeek.Friday);
    RunTests(dtFrom, DayOfWeek.Saturday);
    Console.WriteLine();
}
