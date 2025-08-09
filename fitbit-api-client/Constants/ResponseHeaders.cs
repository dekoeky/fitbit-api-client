namespace fitbit_api_client.Constants;

public static class ResponseHeaders
{
    /// <summary>
    /// The quota number of calls.
    /// </summary>
    public const string RateLimit_Limit = "Fitbit-Rate-Limit-Limit";

    /// <summary>
    /// The number of calls remaining before hitting the rate limit.
    /// </summary>
    public const string RateLimit_Remaining = "Fitbit-Rate-Limit-Remaining";

    /// <summary>
    /// The number of seconds until the rate limit resets.
    /// </summary>
    public const string RateLimit_Reset = "Fitbit-Rate-Limit-Reset";
}