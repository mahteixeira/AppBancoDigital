using BancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BancoDigital.Service
{
    public class DataServiceChavePix : DataService
    {
        public static async Task<object> Adicionar(ChavePix ChaveModel)
        {
            string json = JsonConvert.SerializeObject(ChaveModel);

            string response = await PostDataToService(json, "/conta/pix/adicionar");

            var obj = JsonConvert.DeserializeObject(response);

            ChavePix chavePix = obj as ChavePix;    

            return obj as Conta;

        }
    }
}
