using BancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BancoDigital.Service
{
    public class DataServiceConta : DataService
    {
        public static async Task<Conta> Login(Conta co)
        {
            var json_to_send = JsonConvert.SerializeObject(co);

            string json = await DataService.PostDataToService(json_to_send, "/conta/entrar");

            return JsonConvert.DeserializeObject<Conta>(json);
        }

    }
}
