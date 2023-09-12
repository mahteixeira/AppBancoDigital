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
        public static async Task<Conta> SelectConta(Conta conta_escolhida)
        {
            var json_to_send = JsonConvert.SerializeObject(conta_escolhida);

            string json = await DataService.PostDataToService(json_to_send, "/conta/entrar");

            return JsonConvert.DeserializeObject<Conta>(json);
        }

        public static async Task<object> Cadastrar(Conta contaModel)
        {
            string json = JsonConvert.SerializeObject(contaModel);

            string response = await PostDataToService(json, "/conta/criar");

            var obj = JsonConvert.DeserializeObject(response);

            Conta conta = obj as Conta;

            return obj as Conta;
        }

    }
}
