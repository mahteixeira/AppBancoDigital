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
    public partial class Cadastro_CPF_DATANASC : ContentPage
    {
        public Cadastro_CPF_DATANASC()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            canto.Source = ImageSource.FromResource("BancoDigital.Imagens.canto.png");
        }

        private void btn_continuar_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine(dtpck_data_nasc);
        }
    }
}