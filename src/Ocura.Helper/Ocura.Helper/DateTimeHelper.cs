using System;
using System.Globalization;

namespace Ocura.Helper
{
  public static class DateTimeHelper
  {
    /// <summary>
    ///   Gets the last week.
    /// </summary>
    /// <value>
    ///   The last week.
    /// </value>
    public static int LastWeek => GetLastWeek();

    /// <summary>
    ///   Gets the begin of year.
    /// </summary>
    /// <value>
    ///   The begin of year.
    /// </value>
    public static DateTime BeginOfYear => GetBeginOfYear();

    /// <summary>
    ///   Adds the business days.
    /// </summary>
    /// <param name="date">The date.</param>
    /// <param name="days">The days.</param>
    /// <returns></returns>
    public static DateTime AddBusinessDays(this DateTime date, int days)
    {
      var sign = Math.Sign(days);
      var unsignedDays = Math.Abs(days);
      for (var i = 0; i < unsignedDays; i++)
        do
        {
          date = date.AddDays(sign);
        } while (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday || date.IsHoliday());

      return date;
    }

    /// <summary>
    ///   Determines whether this instance is holiday.
    /// </summary>
    /// <param name="date">The date.</param>
    /// <returns>
    ///   <c>true</c> if the specified date is holiday; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsHoliday(this DateTime date)
    {
      // INSERT YOUR HOlIDAY-CODE HERE!
      return false;
    }

    /// <summary>
    ///   Determines whether [is business day].
    /// </summary>
    /// <param name="date">The date.</param>
    /// <returns>
    ///   <c>true</c> if [is business day] [the specified date]; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsBusinessDay(this DateTime date)
    {
      return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday && !date.IsHoliday();
    }

    /// <summary>
    ///   Dates based in an year and week.
    /// </summary>
    /// <param name="year">The year.</param>
    /// <param name="weekOfYear">The week of year.</param>
    /// <returns></returns>
    public static DateTime DateFromYearWeek(int year, int weekOfYear)
    {
      var jan1 = new DateTime(year, 1, 1);
      var daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;
      var firstThursday = jan1.AddDays(daysOffset);
      var cal = CultureInfo.CurrentCulture.Calendar;
      var firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
      var weekNum = weekOfYear;
      if (firstWeek <= 1) weekNum -= 1;
      var result = firstThursday.AddDays(weekNum * 7);
      return result.AddDays(-3);
    }

    /// <summary>
    ///   Weeks the of year.
    /// </summary>
    /// <param name="time">The time.</param>
    /// <returns></returns>
    public static int WeekOfYear(this DateTime time)
    {
      // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
      // be the same week# as whatever Thursday, Friday or Saturday are,
      // and we always get those right
      var day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
      if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
        time = time.AddDays(3);

      // Return the week of our adjusted day
      return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek,
        DayOfWeek.Monday);
    }

    /// <summary>
    ///   Weeks the of year.
    /// </summary>
    /// <param name="time">The time.</param>
    /// <returns></returns>
    public static int? WeekOfYear(this DateTime? time)
    {
      return time?.WeekOfYear();
    }

    /// <summary>
    ///   Get the month name.
    /// </summary>
    /// <param name="month">The month.</param>
    /// <returns></returns>
    public static string MonthName(int month)
    {
      return new DateTime(DateTime.Today.Year, month, 1).ToString("MMM", CultureInfo.InvariantCulture);
    }

    /// <summary>
    ///   Get the first day of the month
    /// </summary>
    /// <param name="date">The date.</param>
    /// <returns></returns>
    public static DateTime BeginOfMonth(this DateTime date)
    {
      return new DateTime(date.Year, date.Month, 1, 0, 0, 0);
    }

    /// <summary>
    ///   Get the first day of the month
    /// </summary>
    /// <param name="date">The date.</param>
    /// <returns></returns>
    public static DateTime? BeginOfMonth(this DateTime? date)
    {
      return date?.BeginOfMonth();
    }

    /// <summary>
    ///   Get the last day of the month
    /// </summary>
    /// <param name="date">The date.</param>
    /// <returns></returns>
    public static DateTime EndOfMonth(this DateTime date)
    {
      return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month), 23, 59, 59);
    }

    /// <summary>
    ///   Get the last day of the month
    /// </summary>
    /// <param name="date">The date.</param>
    /// <returns></returns>
    public static DateTime? EndOfMonth(this DateTime? date)
    {
      return date?.EndOfMonth();
    }

    /// <summary>
    ///   Gets the last week.
    /// </summary>
    /// <returns></returns>
    private static int GetLastWeek()
    {
      return DateTime.Today.AddDays(-7).WeekOfYear();
    }

    /// <summary>
    ///   Gets the begin of year.
    /// </summary>
    /// <returns></returns>
    private static DateTime GetBeginOfYear()
    {
      return new DateTime(DateTime.Today.Year, 1, 1);
    }
  }
}
