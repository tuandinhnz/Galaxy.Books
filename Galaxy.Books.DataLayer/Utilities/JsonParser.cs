using Newtonsoft.Json;

namespace Galaxy.Books.DataLayer.Utilities
{
    public static class JsonParser
    {
        public static async Task<List<T>?> Parse<T>(string filePath)
        {
            try
            {
                using var reader = new StreamReader(filePath);
                string json = await reader.ReadToEndAsync();
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
