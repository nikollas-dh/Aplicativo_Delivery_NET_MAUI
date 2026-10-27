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
        string urlBase = "http://10.0.2.2:5223/api";
        //string urlBase = "http://192.168.0.1:5223/api";

        public async Task<JsonElement?> Login(Usuario us)
        {
            var res = await client.PostAsJsonAsync($"{urlBase}/Usuario/login", us);
            return res.IsSuccessStatusCode ? await res.Content.ReadFromJsonAsync<JsonElement>() : null;
        }
        public async Task<int> ObterIdRestaurante(int idUsuario)
        {
            return await client.GetFromJsonAsync<int>($"{urlBase}/Admin/restaurante-por-admin/{idUsuario}");
        }

        public async Task<JsonElement> ListarResumoAdmin(int idRestaurante)
        {
            return await client.GetFromJsonAsync<JsonElement>($"{urlBase}/Admin/resumo/{idRestaurante}");
        }

        public async Task<List<Pedido>> ListarPedidosUsuario(int id)
        {
            try
            {
                return await client.GetFromJsonAsync<List<Pedido>>($"{urlBase}/Cliente/{id}");
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