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

        private async void btn_continuar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txt_cpf.Text == "")
                {
                    await DisplayAlert("Ops", "Informe seu CPF para que possamos continuar", "OK");
                }
                else
                {

                    if (dtpck_data_nasc.Date.Year <= 2005)
                    {
                        App.Globais._data_nasc = dtpck_data_nasc.Date;
                        App.Globais._cpf = txt_cpf.Text;

                        await Navigation.PushAsync(new View.Cadastro.Cadastro_SENHA());
                    }
                    else
                    {
                        await DisplayAlert("Sentimos muito!", "No momento apenas gerenciamos contas para maiores de idade, futuramente poderemos trabalhar para você.", "OK");
                    }
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}