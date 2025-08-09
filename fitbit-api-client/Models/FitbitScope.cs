using System.Text.Json.Serialization;

namespace fitbit_api_client.Models;

public enum FitbitScope
{
    /// <summary>
    /// Includes activity data and exercise log related features, such as steps, distance, calories burned, and active minutes.
    /// </summary>
    [JsonPropertyName("activity")]
    Activity,

    /// <summary>
    /// Includes the maximum or optimum rate at which the user’s heart, lungs, and muscles can effectively use oxygen during exercise.
    /// </summary>
    [JsonPropertyName("cardio_fitness")]
    CardioFitness,

    /// <summary>
    /// Includes the user's on-device ECG readings.
    /// </summary>
    [JsonPropertyName("electrocardiogram")]
    Electrocardiogram,

    /// <summary>
    /// Includes the continuous heart rate data and related analysis.
    /// </summary>
    [JsonPropertyName("heartrate")]
    HeartRate,

    /// <summary>
    /// Includes the user's engagement and list of irregular rhythm notification alerts.
    /// </summary>
    [JsonPropertyName("irregular_rhythm_notifications")]
    IrregularRhythmNotifications,

    /// <summary>
    /// Includes the GPS and other location data.
    /// </summary>
    [JsonPropertyName("location")]
    Location,

    /// <summary>
    /// Includes calorie consumption and nutrition related features, such as food/water logging, goals, and plans.
    /// </summary>
    [JsonPropertyName("nutrition")]
    Nutrition,

    /// <summary>
    /// Includes measurements of blood oxygen level.
    /// </summary>
    [JsonPropertyName("oxygen_saturation")]
    OxygenSaturation,

    /// <summary>
    /// Includes basic user information.
    /// </summary>
    [JsonPropertyName("profile")]
    Profile,

    /// <summary>
    /// Includes measurements of average breaths per minute at night.
    /// </summary>
    [JsonPropertyName("respiratory_rate")]
    RespiratoryRate,

    /// <summary>
    /// Includes user account and device settings, such as alarms.
    /// </summary>
    [JsonPropertyName("settings")]
    Settings,

    /// <summary>
    /// Includes sleep logs and related sleep analysis.
    /// </summary>
    [JsonPropertyName("sleep")]
    Sleep,

    /// <summary>
    /// Includes friend-related features, such as friend list and leaderboard.
    /// </summary>
    [JsonPropertyName("social")]
    Social,

    /// <summary>
    /// Includes skin and core temperature data.
    /// </summary>
    [JsonPropertyName("temperature")]
    Temperature,

    /// <summary>
    /// Includes weight and body fat information, such as body mass index, body fat percentage, and goals.
    /// </summary>
    [JsonPropertyName("weight")]
    Weight
}