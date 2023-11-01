using ConsoleApp4.Models;
using System.Text;
using System.Text.Json;

internal class Program
{
    internal static void Main(string[] args)
    {
        string path = @"C:\Users\shohb\OneDrive\Ishchi stol\C# codes\DateTime\ConsoleApp4\Models\NBU_Result.json";
        if(!File.Exists(path))
        {
            File.Create(path);
        }
        var client = new HttpClient();

        var webRequest = new HttpRequestMessage(HttpMethod.Get, "https://nbu.uz/uz/exchange-rates/json/")
        {
            Content = new StringContent("", Encoding.UTF8, "application/json")
        };

        var response = client.Send(webRequest);

        using var reader = new StreamReader(response.Content.ReadAsStream());
        string json = reader.ReadToEnd();

        var result = JsonSerializer.Deserialize<List<NBU>>(json);
        Console.WriteLine(result.Count);
        
        using(StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine(json);
            Console.WriteLine("Jsonga yozildi...");
        }





    }
}

