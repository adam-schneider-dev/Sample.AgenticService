namespace Sample.AgenticService.JsonTransformation;

using System;
using System.Text.Json;
using System.Text.Json.Nodes;

/// <summary>
/// Provides functionality for transforming JSON data by adding a timestamp.
/// </summary>
public class Service
{
    /// <summary>
    /// Transforms the input JSON string by adding a timestamp to it.
    /// </summary>
    /// <param name="inputJson">The JSON string to transform.</param>
    /// <returns>A JSON string with an added 'processedAt' field containing the current UTC time.</returns>
    public string TransformJson(string inputJson)
    {
        // Parse the input JSON
        var inputObject = JsonObject.Parse(inputJson);
    
        // Add a timestamp to the input object directly
        inputObject["processedAt"] = DateTime.UtcNow.ToString("o");
    
        // Return the transformed JSON as string
        return inputObject.ToJsonString();
    }
}    