using BancoDigital.Model;
using BancoDigital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital.View.Cadastro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro_SENHA : ContentPage
    {
        public Cadastro_SENHA()
        {
            InitializeComponent();
            canto.Source = ImageSource.FromResource("BancoDigital.Imagens.canto.png");
        }

        private async void btn_continuar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txt_senha.Text != txt_repete_senha.Text)
                {
                    await DisplayAlert("Epa!", "As senhas não coincidem.", "OK");
                } else
                {
                    App.Globais._senha = txt_senha.Text;

                    await DataServiceCorrentista.Cadastrar(new Correntista
                    {
                        nome = App.Globais._nome,
                        data_nasc = App.Globais._data_nasc,
                        cpf = App.Globais._cpf,
                        senha = App.Globais._senha
                    });


                    await DisplayAlert("Sucesso!", "Você foi cadastrado.", "OK");
                    await Navigation.PushAsync(new View.Login());
                }
            }
            catch (Exception ex) 
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}