using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposTelas.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Modal());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            App.Current.MainPage = new Master.Master();
        }
    }
}