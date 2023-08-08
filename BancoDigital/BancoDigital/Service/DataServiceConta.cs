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

        public static async Task<List<Conta>> GetContasByIdCorrentista(int id_correntista)
        {
            string json = await DataService.GetDataFromService("/conta/listar?id_correntista=" + id_correntista);

            List<Conta> arr_contas = JsonConvert.DeserializeObject<List<Conta>>(json);

            
            Console.WriteLine(arr_contas.Count);
            return arr_contas;
        }
        
    }
}
