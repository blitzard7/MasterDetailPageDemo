using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
        public ListView ListView;

		public MasterPage()
		{
			InitializeComponent();

            BindingContext = new MasterPageViewModel();
            ListView = MenuItemsListView;
            
        }
	}
}