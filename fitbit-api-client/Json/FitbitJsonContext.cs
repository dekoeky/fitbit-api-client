using fitbit_api_client.Models.Internal;
using System.Text.Json.Serialization;

namespace fitbit_api_client.Json;

[JsonSerializable(typeof(WeightResponse))]
[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
public partial class FitbitJsonContext : JsonSerializerContext;
