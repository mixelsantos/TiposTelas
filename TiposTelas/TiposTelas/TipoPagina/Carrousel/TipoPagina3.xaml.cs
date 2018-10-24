using System;
using TiposTelas.TipoPagina.Tabbed;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposTelas.TipoPagina.Carrousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoPagina3 : ContentPage
    {
        public TipoPagina3()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.Page1() { BackgroundColor = Color.Blue});
            App.Current.MainPage = new Abas();
        }
    }
}