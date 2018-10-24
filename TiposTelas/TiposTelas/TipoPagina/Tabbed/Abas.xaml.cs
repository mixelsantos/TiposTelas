
using TiposTelas.TipoPagina.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposTelas.TipoPagina.Tabbed
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Abas : TabbedPage
    {
		public Abas ()
		{
			InitializeComponent ();

            Children.Add(new NavigationPage(new Page1()) { Title = "Item 3"});
		}
	}
}