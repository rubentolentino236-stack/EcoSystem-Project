namespace EcoSystem.Client.Services;

public class ApiService
{
    private readonly HttpClient _http;

    public ApiService(HttpClient http)
    {
        _http = http;
    }

    // Aquí más adelante agregaremos los métodos
    // GET, POST, PUT y DELETE.
}