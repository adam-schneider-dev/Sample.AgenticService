namespace Sample.AgenticService.Test;

using System;
using System.Text.Json;
using System.Text.Json.Nodes;

/// <summary>
/// Contains unit tests for the JsonTransformation.Service class.
/// </summary>
public class Tests
{
    /// <summary>
    /// Sets up the test environment before each test method execution.
    /// </summary>
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// Tests that the TransformJson method correctly adds a timestamp field to the JSON input.
    /// This ensures the service properly enhances JSON data with processing metadata.
    /// </summary>
    [Test]
    public void TransformJson_AddsTimestampField()
    {
        // Yeah
        // Arrange
        var service = new JsonTransformation.Service();
        string inputJson = """
        {
          "name": "John Doe",
          "email": "john.doe@example.com"
        }
        """;

        // Act
        string result = service.TransformJson(inputJson);

        // Assert
        var jsonObject = JsonObject.Parse(result);
        Assert.That(jsonObject["processedAt"], Is.Not.Null);
    
        // Verify the timestamp is a valid ISO 8601 formatted date
        Assert.DoesNotThrow(() => DateTime.Parse(jsonObject["processedAt"].ToString()));
    }
}