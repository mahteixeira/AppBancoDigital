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

                carregando.IsRunning = true;
                carregando.IsVisible = true; 


                if (txt_nome.Text == null | txt_senha.Text == null | txt_cpf.Text == null | txt_confsenha.Text == null)
                {
                    await DisplayAlert("Ops!", "Você provavelmente deixou algo em branco.", "OK");
                }
                else
                {
                    if (txt_senha.Text != txt_confsenha.Text) {

                        await DisplayAlert("Ops!", "As senhas não batem.", "OK");

                    } else { 
                    await DataServiceCorrentista.Cadastrar(new Correntista
                    {
                        nome = txt_nome.Text,
                        data_nasc = dtpck_data_nasc.Date,
                        cpf = txt_cpf.Text,
                        senha = txt_senha.Text
                    });


                    await DisplayAlert("Sucesso!", "Você foi cadastrado.", "OK");
                    await Navigation.PushAsync(new View.Login());

                }
            }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");

            }
            finally
            {
                carregando.IsRunning = false;
                carregando.IsVisible = false;
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