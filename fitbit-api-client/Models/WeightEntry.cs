using System.Text.Json.Serialization;

namespace fitbit_api_client.Models;

public record WeightEntry
{
    [JsonPropertyName("bmi")]
    public double Bmi { get; set; }

    [JsonPropertyName("date")]
    public DateOnly Date { get; set; }

    [JsonPropertyName("fat")]
    public double? Fat { get; set; }

    [JsonPropertyName("logId")]
    public long LogId { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; } = string.Empty;

    [JsonPropertyName("time")]
    public TimeOnly Time { get; set; }

    [JsonPropertyName("weight")]
    public double Weight { get; set; }
}