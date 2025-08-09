using System.Text.Json.Serialization;

namespace fitbit_api_client.Models.Internal;

public record WeightResponse
{
    [JsonPropertyName("weight")]
    public WeightEntry[] Weight { get; set; } = [];
}