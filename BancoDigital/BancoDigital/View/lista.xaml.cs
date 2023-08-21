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
    public partial class lista : ContentPage
    {
        public lista()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            List<Conta> arr_contas = App.DadosCorrentista.lista_conta; 

            lst_contas.ItemsSource = arr_contas;
            logo.Source = ImageSource.FromResource("BancoDigital.Imagens.logo.png");


        }


        private async void conta_criar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Cadastro_CONTA.Cadastro_Conta());
        }
    }
}