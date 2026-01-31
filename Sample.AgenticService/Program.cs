using JsonService = Sample.AgenticService.JsonTransformation;

namespace Program
{
    /// <summary>
    /// The main entry point of the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main method that demonstrates JSON transformation functionality.
        /// </summary>
        /// <param name="args">Command-line arguments (not used in this example).</param>
        public static void Main(string[] args)
        {
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
        }
    }
}
