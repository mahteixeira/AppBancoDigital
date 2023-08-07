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

            string[] resultsArray = explode(" ", App.DadosCorrentista.nome);
            string Nome = resultsArray[0];

            //string Saldo = App.DadosConta.saldo.ToString();

            txt_correntista.Text = Nome;
            //txt_saldo.Text = "R$ " + Saldo;
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

    }
}