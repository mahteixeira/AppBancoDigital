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
    public partial class Feedback : ContentPage
    {
        public Feedback()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            if (App.Globais.deu_certo == true)
            {
                certo_erro.Source = ImageSource.FromResource("BancoDigital.Imagens.verificar.png");
            } else
            {
                certo_erro.Source = ImageSource.FromResource("BancoDigital.Imagens.cancelar.png");
            }

            mensagem.Text = App.Globais.feedback;
        }

        private void btn_continuar_Clicked(object sender, EventArgs e)
        {

        }
    }
}