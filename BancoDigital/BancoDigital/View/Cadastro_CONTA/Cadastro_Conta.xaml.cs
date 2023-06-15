using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital.View.Cadastro_CONTA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro_Conta : ContentPage
    {
        string senha_conta;
        string tipo_conta;

        public Cadastro_Conta()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            canto.Source = ImageSource.FromResource("BancoDigital.Imagens.canto.png");

        }

        private async void btn_continuar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txt_senha_conta.Text == "" || pck_conta.SelectedIndex.ToString() == "")
                {
                    await DisplayAlert("Opa!", "Preencha tudo corretamente", "OK");

                }
                else
                {


                    if (senha_igual.IsChecked == true)
                    {
                        await DisplayAlert("Tome cuidado!", "Tenha noção que estamos falando de dinheiro, e sua segurança é a mais importante XD", "Estou ciente disso!");
                        senha_conta = App.Globais._senha;
                        txt_senha_conta.IsEnabled = false;
                    }
                    else
                    {
                        senha_conta = txt_senha_conta.Text;
                        App.Globais._senha = senha_conta;
                        txt_senha_conta.IsEnabled = true;
                    }

                    tipo_conta = pck_conta.SelectedIndex.ToString();
                    App.Globais._tipo_conta = tipo_conta;

                    senha_conta = txt_senha_conta.Text;
                    App.Globais._senha = senha_conta;
                    
                    await Navigation.PushAsync(new View.Cadastro_CONTA.Numero_Conta());


                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }
    }
}