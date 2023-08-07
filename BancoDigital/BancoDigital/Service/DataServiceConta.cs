using BancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BancoDigital.Service
{
    public class DataServiceConta : DataService
    {

        public static async Task<List<Conta>> ListarContas(int id_correntista)
        {
            List<Conta> arr_contas = new List<Conta>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://0.0.0.0:8000/conta/listar?id_correntista=" + id_correntista);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_contas = JsonConvert.DeserializeObject<List<Conta>>(json);
                }

                return arr_contas;
            }
        }
    }
}
