using BancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

            public static async Task<bool> Cadastrar(Correntista c)
            {
                var json_a_enviar = JsonConvert.SerializeObject(c);

                string json = await DataService.PostDataToService(json_a_enviar, "/correntista/save");

                return true;
            }

        public static async Task<List<Correntista>> SearchAsync(string q)
            {
                var json_a_enviar = JsonConvert.SerializeObject(q);

                string json = await DataService.PostDataToService(json_a_enviar, "/correntista/buscar");

                List<Correntista> arr_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

                return arr_correntistas;
            }

            public static async Task<List<Correntista>> DeleteAsync(int id)
            {
                var json_a_enviar = JsonConvert.SerializeObject(id);

                string json = await DataService.PostDataToService(json_a_enviar, "/correntista/delete");

                List<Correntista> arr_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

                return arr_correntistas;
            }

        }
    }
