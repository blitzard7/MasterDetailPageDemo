using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainTabbedPage : TabbedPage
	{
		public MainTabbedPage()
		{
			InitializeComponent();

            var tabbedOneNav = new NavigationPage(new TabbedItem())
            {
                Title = "Item One"
            };

            var tabbedOTwoNav = new NavigationPage(new TabbedItem())
            {
                Title = "Item Two"
            };

            var tabbedThreeNav = new NavigationPage(new TabbedItem())
            {
                Title = "Item Three"
            };

            this.Children.Add(tabbedOneNav);
            this.Children.Add(tabbedOTwoNav);
            this.Children.Add(tabbedThreeNav);
        }
	}
}