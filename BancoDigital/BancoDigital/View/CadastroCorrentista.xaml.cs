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
            NavigationPage.SetHasNavigationBar(this, false);
            canto.Source = ImageSource.FromResource("BancoDigital.Imagens.canto.png");
           
        }

        private async void btn_cadastro_Clicked(object sender, EventArgs e)
        {
            try
            {
                await DataServiceCorrentista.Cadastrar(new Correntista
                {
                    nome = txt_nome.Text,
                    data_nasc = dtpck_data_nasc.Date,
                    cpf = txt_cpf.Text,
                    senha = txt_senha.Text
                });


                await DisplayAlert("Sucesso!","Você foi cadastrado.", "OK");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");

            }
        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {
            try
            {

                await Navigation.PushAsync(new View.Login());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}