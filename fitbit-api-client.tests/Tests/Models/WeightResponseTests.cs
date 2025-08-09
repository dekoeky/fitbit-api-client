using fitbit_api_client.Json;
using fitbit_api_client.Models;
using fitbit_api_client.Models.Internal;
using System.Text.Json;

namespace fitbit_api_client.Tests.Models;

[TestClass]
public sealed class WeightResponseTests
{
    private const string ExampleJson = """
                                           {
                                             "weight": [
                                               {
                                                 "bmi": 25.91,
                                                 "date": "2019-02-25",
                                                 "fat": 21,
                                                 "logId": 1551080804000,
                                                 "source": "Aria",
                                                 "time": "07:46:44",
                                                 "weight": 200
                                               },
                                               {
                                                 "bmi": 25.91,
                                                 "date": "2019-03-01",
                                                 "logId": 1551484799000,
                                                 "source": "API",
                                                 "time": "23:59:59",
                                                 "weight": 200
                                               }
                                             ]
                                           }
                                           """;

    private static readonly WeightResponse ExamplePoco = new WeightResponse
    {
        Weight =
        [
            new WeightEntry
            {
                Bmi = 25.91,
                Date = new DateOnly(2019,02,25),
                Fat=21,
                LogId = 1551080804000,
                Source = "Aria",
                Time = new TimeOnly(07,46,44),
                Weight =200,
            },
            new WeightEntry
            {
                Bmi = 25.91,
                Date = new DateOnly(2019,03,01),
                LogId = 1551484799000,
                Source = "API",
                Time = new TimeOnly(23,59,59),
                Weight=200,
            }
        ]
    };

    [TestMethod]
    public void Deserialize()
    {
        //Act
        var result = JsonSerializer.Deserialize(ExampleJson, FitbitJsonContext.Default.WeightResponse);

        //Assert
        Assert.IsNotNull(result);
        CollectionAssert.AreEqual(ExamplePoco.Weight, result.Weight);
    }

    [TestMethod]
    public void Serialize()
    {
        //Act
        var json = JsonSerializer.Serialize(ExamplePoco, FitbitJsonContext.Default.WeightResponse);

        //Assert
        Console.WriteLine(json);
        Assert.AreEqual(ExampleJson, json);
    }
}