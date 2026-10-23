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
        string urlBase = "http://192.168.0.1:5223/api";

        public async Task<(int pendentes, int entregues, int emTransito, int cancelados)> ListarResumoAdmin()
        {
            var res = await client.GetFromJsonAsync<JsonElement>(
                $"{urlBase}/Admin/resumo");

            return (
                res.GetProperty("pendentes").GetInt32(),
                res.GetProperty("entregues").GetInt32(),
                res.GetProperty("emTransito").GetInt32(),
                res.GetProperty("cancelados").GetInt32()
            );
        }


        public async Task<JsonElement> Login(Usuario us)
        {
            var res = await client.PostAsJsonAsync($"{urlBase}/Usuario/login", us);
            res.EnsureSuccessStatusCode();
            return await res.Content.ReadFromJsonAsync<JsonElement>();
        }

        public async Task<List<Pedido>> ListarPedidosUsuario(int id) 
        {
            var res = await client.GetFromJsonAsync<List<Pedido>>($"{urlBase}/Cliente/{id}");
            return res;
        }
        public async Task<List<Pedido>> ListarPedidosEntregador() 
        {
            var res = await client.GetFromJsonAsync<List<Pedido>>($"{urlBase}/Entregador");
            return res;
        }


    }
}
