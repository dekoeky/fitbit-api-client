using System.Text.Json.Serialization;

namespace fitbit_api_client.Models;

[JsonConverter(typeof(JsonStringEnumConverter<Period>))]
public enum Period
{
    [JsonStringEnumMemberName("1d")]
    OneDay,

    [JsonStringEnumMemberName("7d")]
    SevenDays,

    [JsonStringEnumMemberName("30d")]
    ThirtyDays,

    [JsonStringEnumMemberName("1w")]
    OneWeek,

    [JsonStringEnumMemberName("1m")]
    OneMonth,
}