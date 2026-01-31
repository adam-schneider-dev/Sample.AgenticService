namespace Sample.AgenticService.JsonTransformation;

using System;
using System.Text.Json;
using System.Text.Json.Nodes;

public class Service
{
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