﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital.View.Cadastro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro_NOME : ContentPage
    {
        public Cadastro_NOME()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            canto.Source = ImageSource.FromResource("BancoDigital.Imagens.canto.png");
        }

        private async void btn_continuar_Clicked(object sender, EventArgs e)
        {
            try
            { 
                string nome = txt_nome.Text;
                string sobrenome = txt_sobrenome.Text;  
                if (txt_nome.Text == null | txt_sobrenome.Text == null)
                {
                    await DisplayAlert("Epa!", "Informe seu nome completo para continuar.", "OK");
                } else
                {
                    App.Globais._nome = nome + " " + sobrenome;

                    await Navigation.PushAsync(new View.Cadastro.Cadastro_CPF_DATANASC());
                }
            }
            catch (Exception ex) 
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            } 
          

        }
    }
}