using BoletosBus.WebApplication.Models;
using BoletosBus.WebApplication.Services;
using System.Text.Json;

namespace BoletosBus.WebApplication.Implementation
{
    public class UsuarioServiceImplementation : IUsuarioService
    {
        private readonly HttpClient _httpClient;

        public UsuarioServiceImplementation(HttpClient httpClient)
        {
             _httpClient = httpClient;
        }


        public async Task<List<UsuarioModel>> GetAll()
        {
            using (var response = await _httpClient.GetAsync("Usuario/GetAllUsuario"))
            {
              

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var lista = JsonSerializer.Deserialize<List<UsuarioModel>>(jsonResponse, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return lista;
                }
                else
                {
                    throw new HttpRequestException($"La solicitud falló con el estado {response.StatusCode}.");
                }


            }
        }

        public async Task<UsuarioModel> GetById(int id)
        {
            using (var response = await _httpClient.GetAsync($"Usuario/GetUsuarioById/{id}"))
            {
                

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var usuario = JsonSerializer.Deserialize<UsuarioModel>(jsonResponse, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return usuario;
                }
                else
                {
                    throw new HttpRequestException($"La solicitud falló con el estado {response.StatusCode}.");
                }


            }
        }



        public async Task<List<UsuarioModel>> GetAllUsuarioByTipoUsuario(string tipoUsuario)
        {
            using (var response = await _httpClient.GetAsync($"Usuario/GetAllUsuarioByTipoUsuario?tipoUsuario={tipoUsuario}"))
            {
                

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var lista = JsonSerializer.Deserialize<List<UsuarioModel>>(jsonResponse, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return lista;
                }
                else
                {
                    throw new HttpRequestException($"La solicitud falló con el estado {response.StatusCode}.");
                }


            }
        }

        

        public Task Save(UsuarioModel model)
        {
            throw new NotImplementedException();
        }

        public Task Update(UsuarioModel model)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
