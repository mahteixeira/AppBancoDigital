﻿using BancoDigital.Model;
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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            frm_login.BackgroundColor = Color.FromRgba(1, 1, 1, 0.8);
            logo.Source = ImageSource.FromResource("BancoDigital.Imagens.logo.png");
            canto.Source = ImageSource.FromResource("BancoDigital.Imagens.canto.png");
            canto2.Source = ImageSource.FromResource("BancoDigital.Imagens.canto2.png");
        }

        private async void btn_cadastro_Clicked(object sender, EventArgs e)
        {
            try
            {

                await Navigation.PushAsync(new View.CadastroCorrentista());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}