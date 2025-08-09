namespace fitbit_api_client.Models;

public static class PeriodExtensions
{
    public static string ToPath(this Period period) => period switch
    {
        Period.OneDay => "1d",
        Period.SevenDays => "7d",
        Period.ThirtyDays => "30d",
        Period.OneWeek => "1w",
        Period.OneMonth => "1m",
        _ => throw new ArgumentOutOfRangeException(nameof(period), period, null)
    };
}