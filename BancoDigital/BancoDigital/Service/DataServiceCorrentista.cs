using BancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {

            public static async Task<List<Correntista>> GetPessoasAsync()
            {
                string json = await DataService.GetDataFromService("/correntista");

                List<Correntista> arr_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

                return arr_correntistas;
            }

        public static async Task<object> Cadastrar(Correntista correntistaModel)
        {
            string json = JsonConvert.SerializeObject(correntistaModel);

            string response = await PostDataToService(json, "/correntista/save");

            var obj = JsonConvert.DeserializeObject(response);

            Correntista correntista = obj as Correntista;

            if (correntista != null)
                return obj as Correntista;
            else
                throw new Exception("Algo está errado");
        }

        /*public static async Task<List<Correntista>> ConferirLogin(string cpf, string senha)
            {
            
            } */

            public static async Task<List<Correntista>> DeleteAsync(int id)
            {
                var json_a_enviar = JsonConvert.SerializeObject(id);

                string json = await DataService.PostDataToService(json_a_enviar, "/correntista/delete");

                List<Correntista> arr_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

                return arr_correntistas;
            }

        }
    }
