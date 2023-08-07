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
            NavigationPage.SetHasNavigationBar(this, false);
            canto.Source = ImageSource.FromResource("BancoDigital.Imagens.canto.png");
        }

        private async void btn_continuar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txt_senha.Text == null | txt_repete_senha.Text == null)
                {
                    await DisplayAlert("Epa!", "Precisamos confirmar uma senha para continuar.", "OK");
                }
                else
                {
                    if (txt_senha.Text != txt_repete_senha.Text)
                    {
                        await DisplayAlert("Epa!", "As senhas não coincidem.", "OK");
                    }
                    else
                    {
                        App.Globais._senha = txt_senha.Text;

                        await DataServiceCorrentista.Cadastrar(new Correntista
                        {
                            nome = App.Globais._nome,
                            data_nasc = App.Globais._data_nasc,
                            cpf = App.Globais._cpf,
                            senha = App.Globais._senha
                        });

                        App.Globais.deu_certo = true;

                        App.Globais.feedback = "Você foi cadastrado(a) com sucesso!! Agora você faz parte da nossa família <3";
                        App.Globais.pra_onde = "inicio";
                        await Navigation.PushAsync(new View.Feedback());

                        /*
                        Correntista correntista = await DataServiceCorrentista.Login(new Correntista
                        {
                            cpf = App.Globais._cpf,
                            senha = App.Globais._senha
                        });
                        App.Globais.pra_onde = "inicio";
                        App.Globais.feedback = "Você foi cadastrado(a) com sucesso!! Agora você faz parte da nossa família <3";
                        await Navigation.PushAsync(new View.Feedback());
                        */
                    }
                }
            }
            catch 
            {
                App.Globais.deu_certo = false;
                App.Globais.pra_onde = "login";
                App.Globais.feedback = "Sentimos muito, mas algo em nosso sistema deu errado :(( Tente novamente dentro de algum tempo.";
                await Navigation.PushAsync(new View.Feedback());
            }
        }
    }
}