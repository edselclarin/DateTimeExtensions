# DateTimeExtensions

This class contains the following extension methods for the DateTime class:

DateTime GetDateOfTarget(this DateTime dateTime, DayOfWeek targetDayOfWeek)

This method returns the date of the specified day of week after the given date.

Usage:

DateTime dtFrom = new DateTime(2022, 11, 19);
<br/>
DateTime dtNext = dtFrom.GetDateOfTarget(DayOfWeek.Thursday);
<br/>

Result: 11/24/2022

