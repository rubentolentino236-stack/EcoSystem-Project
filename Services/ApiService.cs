using System.Net.Http.Json;
using EcoSystem.Client.Models;

namespace EcoSystem.Client.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Producto>> ObtenerProductosAsync()
    {
        try
        {
            var productos = await _httpClient
                .GetFromJsonAsync<List<Producto>>("api/productos");

            return productos ?? new List<Producto>();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error al consultar la API: {ex.Message}");
            return new List<Producto>();
        }
    }
}