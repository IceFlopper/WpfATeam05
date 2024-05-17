using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ClassLibTeam05.Business;

public class DataService
{
    private readonly HttpClient _httpClient;

    public DataService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Cars>> GetDataAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<List<Cars>>("https://your-api-endpoint.com/data");
        return response;
    }
}