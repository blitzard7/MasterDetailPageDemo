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
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(usernameEntry.Text) && string.IsNullOrEmpty(passwordEntry.Text)))
            {
                Navigation.PushModalAsync(new MainPage());
            }
        }
    }
}