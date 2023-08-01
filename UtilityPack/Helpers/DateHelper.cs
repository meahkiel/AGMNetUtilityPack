namespace UtilityPack.Helpers;

public static class DateHelper
{
    public static DateTime MergeDateTime(this DateTime date, string time) {
        return DateTime.Parse($"{date.ToShortDateString()} {time}");
    }

}
