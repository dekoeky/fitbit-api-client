using fitbit_api_client.Constants;
using fitbit_api_client.Exceptions;
using fitbit_api_client.Models;
using fitbit_api_client.Models.Internal;
using System.Net.Http.Json;

namespace fitbit_api_client;

public class FitbitApiClient(HttpClient client) : IFitbitApiClient
{
    public const string DefaultBaseUri = "https://api.fitbit.com";
    private static readonly Uri DefaultUri = new Uri(DefaultBaseUri);

    public FitbitApiClient() : this(new HttpClient { BaseAddress = DefaultUri })
    {

    }

    public async Task<WeightEntry[]> GetWeightTimeSeries(DateOnly date, Period period, string? userId = null, CancellationToken cancellationToken = default)
    {
        var path = $"/1/user/{userId ?? Paths.CurrentLoggedInUser}/body/log/weight/date/{date:yyyy-MM-dd}/{period.ToPath()}.json";

        var response = await client.GetFromJsonAsync<WeightResponse>(path, cancellationToken) ?? throw new ReturnDataNullException();

        return response.Weight;

    }

    public async Task<WeightEntry[]> GetWeightTimeSeries(DateOnly startDate, DateOnly endDate, string? userId = null, CancellationToken cancellationToken = default)
    {
        //TODO: validate startdate < enddate
        //TODO: validate enddate-startdate <= 31 days

        var path = $"/1/user/{userId ?? Paths.CurrentLoggedInUser}/body/log/weight/date/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}.json";

        var response = await client.GetFromJsonAsync<WeightResponse>(path, cancellationToken) ?? throw new ReturnDataNullException();

        return response.Weight;
    }
}