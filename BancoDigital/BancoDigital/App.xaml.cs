using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital
{
    public partial class App : Application
    {

        public static Model.Correntista DadosCorrentista { get; set; }
        //public static Model.Conta DadosConta { get; set; }

        public App()
        {
            InitializeComponent();

            /*
            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new View.Inicio());
            else
                MainPage = new NavigationPage(new View.Login());
            */

            MainPage = new NavigationPage(new View.Inicio());
        }

        public static class Globais
        {
            public static string _nome = "";
            public static string _sobrenome = "";
            public static string _cpf;
            public static DateTime _data_nasc;
            public static string _senha;
            public static string feedback;
            public static bool deu_certo;
            public static string _tipo_conta;
            public static int _id_correntista;
            public static string pra_onde;
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
