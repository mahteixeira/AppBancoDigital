using BancoDigital.Service;
using BancoDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroCorrentista : ContentPage
    {
        public CadastroCorrentista()
        {
            InitializeComponent();
        }

        private async void btn_cadastro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Correntista c = await DataServiceCorrentista.Cadastrar(new Correntista
                {
                    nome = txt_nome.Text,
                    data_nasc = dtpck_data_nasc.Date
                });

                string msg = $"Pessoa inserida com sucesso. Código gerado: {c.id} ";

                await DisplayAlert("Sucesso!", msg, "OK");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");

            }
        }
    }
}