namespace fitbit_api_client.Constants;

public static class RequestHeaders
{
    /// <summary>
    /// Specify the token type and Fitbit user’s access token [required].
    /// Token type: Bearer
    /// </summary>
    public const string Authorization = "authorization";

    /// <summary>
    /// Defines the media type of the response content the client is expecting [optional].
    /// Supported: application/json
    /// </summary>
    public const string Accept = "accept";

    /// <summary>
    /// The measurement unit system to use for response values [recommended].
    /// See <see href="https://dev.fitbit.com/build/reference/web-api/developer-guide/application-design/#Localization"/>.
    /// </summary>
    public const string AcceptLanguage = "accept-language";

    /// <summary>
    /// The locale to use for response values.
    /// See <see href="https://dev.fitbit.com/build/reference/web-api/developer-guide/application-design/#Localization"/>.
    /// </summary>
    public const string AcceptLocale = "accept-locale";
}