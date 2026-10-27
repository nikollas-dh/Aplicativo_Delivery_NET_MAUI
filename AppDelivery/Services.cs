using AppDelivery.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace AppDelivery
{
    class Services
    {
        HttpClient client = new HttpClient();
        //string urlBase = "http://192.168.0.1:5223/api";
        string urlBase = "http://10.0.2.2:5223/api";

        public async Task<int> ObterIdRestaurante(int idUsuario)
        {
            return await client.GetFromJsonAsync<int>($"{urlBase}/Admin/restaurante-por-admin/{idUsuario}");
        }

        public async Task<(int pendentes, int entregues, int emTransito, int cancelados)>
            ListarResumoAdmin(int idRestaurante)
        {
            var res = await client.GetFromJsonAsync<JsonElement>(
                $"{urlBase}/Admin/resumo/{idRestaurante}");

            return (
                res.GetProperty("pendentes").GetInt32(),
                res.GetProperty("entregues").GetInt32(),
                res.GetProperty("emTransito").GetInt32(),
                res.GetProperty("cancelados").GetInt32()
            );
        }

        public async Task<JsonElement?> Login(Usuario us)
        {
            try
            {
                string api = $"{urlBase}/Usuario/login";

                string json = JsonSerializer.Serialize(us);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var res = await client.PostAsync(api, content);

                if (res.IsSuccessStatusCode)
                {
                    var resBody = await res.Content.ReadAsStringAsync();

                    return JsonSerializer.Deserialize<JsonElement>(resBody);
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no login: {ex.Message}");
                return null;
            }
        }

        public async Task<List<Pedido>> ListarPedidosUsuario(int id)
        {
            try
            {
                var api = $"{urlBase}/Cliente/{id}";

                var pedidos = await client.GetFromJsonAsync<List<Pedido>>(api);

                return pedidos ?? new List<Pedido>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar pedidos: {ex.Message}");
                return new List<Pedido>();
            }
        }

        public async Task<List<Pedido>> ListarPedidosEntregador()
        {
            var res = await client.GetFromJsonAsync<List<Pedido>>($"{urlBase}/Entregador");
            return res;
        }
    }
}