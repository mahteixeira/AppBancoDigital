using BancoDigital.Model;
using BancoDigital.Service;
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
                        var resultado = await DisplayAlert("Tome cuidado!", "Tenha noção que estamos falando de dinheiro, e sua segurança é a mais importante XD", "Estou ciente disso!" , "Quero mudar");
                        if (resultado == true)
                        {
                            senha_conta = App.DadosCorrentista.senha;
                            tipo_conta = pck_conta.SelectedIndex.ToString();
                            if (tipo_conta == "0")
                            {
                                tipo_conta = "Conta Corrente";
                            } else
                            {
                                tipo_conta = "Conta Poupança";
                            }


                            Random random = new Random();
                            string n_pt1 = random.Next(10000000, 99999999).ToString();
                            string n_pt2 = random.Next(0, 9).ToString();

                            string numero = n_pt1 + "-" + n_pt2;


                            await DataServiceConta.Cadastrar(new Conta
                            {
                                numero = numero,
                                tipo = tipo_conta,
                                senha = senha_conta,
                                id_correntista = App.DadosCorrentista.id,
                                saldo = 0,
                                limite = 0
                            });

                            await Navigation.PushAsync(new View.lista());


                        }



                    }
                    else
                    {
                        senha_conta = txt_senha_conta.Text;


                        tipo_conta = pck_conta.SelectedIndex.ToString();


                        senha_conta = txt_senha_conta.Text;


                        Random random = new Random();
                        string n_pt1 = random.Next(10000000, 99999999).ToString();
                        string n_pt2 = random.Next(0, 9).ToString();

                        string numero = n_pt1 + "-" + n_pt2;


                        await DataServiceConta.Cadastrar(new Conta
                        {
                            numero = numero,
                            tipo = tipo_conta,
                            senha = senha_conta,
                            id_correntista = App.DadosCorrentista.id,
                            saldo = 0,
                            limite = 0
                        });

                        await Navigation.PushAsync(new View.lista());


                    }








                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }
    }
}