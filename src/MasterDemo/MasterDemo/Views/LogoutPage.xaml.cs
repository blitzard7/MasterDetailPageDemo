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
	public partial class LogoutPage : ContentPage
	{
		public LogoutPage()
		{
			InitializeComponent();
		}

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Warning", "Are you sure you want to leave? :c", "Yes", "No");

            if (answer)
            {
                await Navigation.PushModalAsync(new LoginPage());
            }
        }
    }
}