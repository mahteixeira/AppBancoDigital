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

            App.Globais._id_correntista = App.DadosCorrentista.id;
            int id_correntista = App.Globais._id_correntista;

            List<Conta> arr_cidades = DataServiceConta.ListarContas(id_correntista);

        }
    }
}