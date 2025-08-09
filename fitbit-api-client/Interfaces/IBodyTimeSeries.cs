using fitbit_api_client.Models;

namespace fitbit_api_client.Interfaces;

/// <summary>
/// [Body Time Series] The Body Time Series endpoints are used for querying body fat and weight data over
/// a period of time either by specifying a date and time period, or a date range.
/// </summary>
/// <seealso href="https://dev.fitbit.com/build/reference/web-api/body-timeseries/"/>
public interface IBodyTimeSeries
{
    /// <summary>
    /// Get Weight Time Series by Date Range.
    /// </summary>
    Task<WeightEntry[]> GetWeightTimeSeries(DateOnly date, Period period, string? userId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Weight Time Series by Date.
    /// </summary>
    Task<WeightEntry[]> GetWeightTimeSeries(DateOnly startDate, DateOnly endDate, string? userId = null, CancellationToken cancellationToken = default);
}