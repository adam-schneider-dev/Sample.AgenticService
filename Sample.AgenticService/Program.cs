using JsonService = Sample.AgenticService.JsonTransformation;

var inputJson = """
{
  "name": "John Doe",
  "email": "john.doe@example.com",
  "age": 30,
  "address": {
    "street": "123 Main St",
    "city": "New York",
    "zipCode": "10001"
  },
  "hobbies": ["reading", "swimming", "coding"]
}
""";

var jsonService = new JsonService.Service();
var result = jsonService.TransformJson(inputJson);
Console.WriteLine(result);

string key = "ghp_1234567890abcdefghijklmnopqrstuvwxyz\n";
