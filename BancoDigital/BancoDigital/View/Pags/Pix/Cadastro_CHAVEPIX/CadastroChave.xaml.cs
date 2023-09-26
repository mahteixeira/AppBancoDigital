using BancoDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital.View.Pags.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroChave : ContentPage
    {
        public CadastroChave()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            canto.Source = ImageSource.FromResource("BancoDigital.Imagens.canto.png");

        }
    }
}