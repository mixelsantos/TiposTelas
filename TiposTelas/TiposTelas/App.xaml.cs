﻿using System;
using TiposTelas.TipoPagina.Carrousel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TiposTelas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new IntroducaoApp();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
