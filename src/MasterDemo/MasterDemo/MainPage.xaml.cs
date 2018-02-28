using MasterDemo.Views;
using System;
using Xamarin.Forms;

namespace MasterDemo
{
    /// <summary>
    /// Represents the <see cref="MainPage"/> class.
    /// </summary>
	public partial class MainPage : MasterDetailPage
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
		public MainPage()
		{
			InitializeComponent();
            LocalMasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItem;
            if (item == null)
                return;

            if (item.TargetType == typeof(MainTabbedPage))
            {
                Navigation.PushModalAsync(new MainTabbedPage());
                return;
            }

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            LocalMasterPage.ListView.SelectedItem = null;
        }
    }
}