using BancoDigital.Model;
using BancoDigital.Service;
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
    public partial class Login : ContentPage
    {
        bool ativado = false;

        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            frm_login.BackgroundColor = Color.FromRgba(1, 1, 1, 0.8);
            logo.Source = ImageSource.FromResource("BancoDigital.Imagens.logo.png");
            canto.Source = ImageSource.FromResource("BancoDigital.Imagens.canto.png");
            canto2.Source = ImageSource.FromResource("BancoDigital.Imagens.canto2.png");
            visivel.Source = ImageSource.FromResource("BancoDigital.Imagens.olho.png");

           
        }

        private async void btn_cadastro_Clicked(object sender, EventArgs e)
        {
            try
            {

                await Navigation.PushAsync(new View.Cadastro.Cadastro_NOME());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void btn_entrar_Clicked(object sender, EventArgs e)
        {
            string cpf = txt_cpf.Text;
            string senha = txt_senha.Text;


            try
            {

                Correntista c = await DataServiceCorrentista.Login(new Model.Correntista
                {
                    cpf = txt_cpf.Text,
                    senha = txt_senha.Text,
                });

                if (c.id != null)
                {
                    App.DadosCorrentista = c;
                    await Navigation.PushAsync(new View.lista());
                    //App.Current.Properties.Add("usuario_logado", c);

                }
                else
                    throw new Exception("Dados de login inválidos.");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void visivel_Clicked(object sender, EventArgs e)
        {

            if (ativado == false)
            {
                ativado = true;
                txt_senha.IsPassword = ativado;
                visivel.Source = ImageSource.FromResource("BancoDigital.Imagens.olho.png");

            } else if (ativado == true)
            {
                ativado = false;
                txt_senha.IsPassword = ativado;
                visivel.Source = ImageSource.FromResource("BancoDigital.Imagens.olhoFechado.png");
            }
        }
    }
}