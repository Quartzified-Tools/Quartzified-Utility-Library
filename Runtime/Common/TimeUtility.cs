using System;

namespace Quartzified.Common
{
    public static class TimeUtility
    {
        public static string PrettySeconds(float seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            string res = "";
            if (t.Days > 0) res += t.Days + "d";
            if (t.Hours > 0) res += " " + t.Hours + "h";
            if (t.Minutes > 0) res += " " + t.Minutes + "m";

            if (t.Milliseconds > 0) res += " " + t.Seconds + "." + (t.Milliseconds / 100) + "s";
            else if (t.Seconds > 0) res += " " + t.Seconds + "s";

            return res != "" ? res : "0s";
        }

        public static string GetMonthName(DateTime date, bool shortName = false)
        {
            if (shortName)
            {
                switch (date.Month)
                {
                    case 1:
                        return "Jan";
                    case 2:
                        return "Feb";
                    case 3:
                        return "Mar";
                    case 4:
                        return "Apr";
                    case 5:
                        return "May";
                    case 6:
                        return "Jun";
                    case 7:
                        return "Jul";
                    case 8:
                        return "Aug";
                    case 9:
                        return "Sep";
                    case 10:
                        return "Oct";
                    case 11:
                        return "Nov";
                    case 12:
                        return "Dec";
                    default:
                        return "Quartzified";

                }
            }
            else
            {
                switch (date.Month)
                {
                    case 1:
                        return "January";
                    case 2:
                        return "February";
                    case 3:
                        return "March";
                    case 4:
                        return "April";
                    case 5:
                        return "May";
                    case 6:
                        return "June";
                    case 7:
                        return "July";
                    case 8:
                        return "August";
                    case 9:
                        return "September";
                    case 10:
                        return "October";
                    case 11:
                        return "November";
                    case 12:
                        return "December";
                    default:
                        return "Quartzified";

                }
            }

        }

        public static string FormatTimespan(float _remaining)
        {
            return FormatTimespan(TimeSpan.FromSeconds(_remaining));
        }

        public static string FormatTimespan(TimeSpan _timespan)
        {
            if (_timespan.TotalHours >= 1)
            {
                return Math.Truncate(_timespan.TotalHours) + "h " + _timespan.Minutes.ToString("00m ") + _timespan.Seconds.ToString("00s");
            }
            else if (_timespan.TotalMinutes >= 1)
            {
                return _timespan.Minutes + "m " + _timespan.Seconds.ToString("00s");
            }
            return _timespan.Seconds + "s";
        }
    }
}
