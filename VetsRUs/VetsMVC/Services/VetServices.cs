using System.Net.Http.Json;
using VetsMVC.Models;

namespace VetsMVC.Services
{
    public class VetServices
    {
        private readonly HttpClient _httpClient;

        public VetServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Cat CRUD Methods from API
        // Get all cats 
        public async Task<List<Cat>> GetAllCats() =>
            await _httpClient.GetFromJsonAsync<List<Cat>>("http://localhost:8080/cats");

        // Get a cat 
        public async Task<Cat?> GetCat(int id) =>
            await _httpClient.GetFromJsonAsync<Cat>($"http://localhost:8080/cats/{id}");

        // Creat a new cat entry
        public async Task CreateCat(Cat cat) =>
            await _httpClient.PostAsJsonAsync("http://localhost:8080/addcat", cat);

        // Update a cats entry
        public async Task UpdateCat(int id, Cat cat) =>
            await _httpClient.PutAsJsonAsync($"http://localhost:8080/cats/{id}", cat);

        // Remove a cat
        public async Task DeleteCat(int id) =>
            await _httpClient.DeleteAsync($"http://localhost:8080/removecat/{id}");

//--------------------------------------------------------------------------------------------------
        // Dog CRUD Methods from API
        // Get all dogs 
        public async Task<List<Dog>> GetAllDogs() =>
            await _httpClient.GetFromJsonAsync<List<Dog>>("http://localhost:8080/dogs");

        // Get a dog
        public async Task<Dog?> GetDog(int id) =>
            await _httpClient.GetFromJsonAsync<Dog>($"http://localhost:8080/dogs/{id}");

        // Create a new dog entry
        public async Task CreateDog(Dog dog) =>
            await _httpClient.PostAsJsonAsync("http://localhost:8080/adddog", dog);

        // Update a dogs entry
        public async Task UpdateDog(int id, Dog dog) =>
            await _httpClient.PutAsJsonAsync($"http://localhost:8080/dogs/{id}", dog);

        // Remove a dog
        public async Task DeleteDog(int id) =>
            await _httpClient.DeleteAsync($"http://localhost:8080/removedog/{id}");
    }
}
