using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_voltar.Source = ImageSource.FromResource("BancoDigital.Imagens.voltar.png");
            btn_perfil.Source = ImageSource.FromResource("BancoDigital.Imagens.perfil.png");
            btn_extrato.Source = ImageSource.FromResource("BancoDigital.Imagens.extrato.png");



            //string[] resultsArray = explode(" ", App.DadosCorrentista.nome);
            //string Nome = resultsArray[0];

            //string Saldo = App.DadosConta.saldo.ToString();

            txt_correntista.Text = "Nome";
           
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_perfil_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_extrato_Clicked(object sender, EventArgs e)
        {

        }
    }
}