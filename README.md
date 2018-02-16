# MasterDetailPageDemo
This project contains a demo of a MasterDetailPage in xamarin.

## Creating a MasterDetailPage
Create a new Crossplatform (Xamarin.Forms) application. <br />
Navigate to the MainPage.xaml and set the ```<ContentPage>``` tag to ```<MasterDetailPage>```. <br />
Example: <br />
```xaml
<MasterDetailPage xmlns="http://xamarin.com/schemas/2014/forms"
                  xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                  x:Class="MasterPageDemo.MainPage"
                  xmlns:pages="clr-namespace:MasterPageDemo">
             
             ....
             ....
</MasterDetailPage>
``` 
Following you need to create a new ContentPage for the detail page of your application.
This page contains the details of each menu item. <br />
An example of a detail page:
``` xaml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MasterPageDemo.MasterPageDetail"
             Title="Detail">
  <StackLayout Padding="10">
    <Label Text="This is a detail page."/>
  </StackLayout>
</ContentPage>
``` 
Create a new ContentPage for your master page, where you will bind your menu items as an ItemSource in a ListView.
You will find an example of a master page in this project. 
After setting up you MasterPage.xaml you have to create a class for your menu items. 
Then you need to set up a ViewModel for your MasterPage, containing an ObservableCollection of your menu items.
At the end you have to declare the MasterPage and the DetailPage in your MainPage.xaml as follows:
``` xaml
<MasterDetailPage xmlns="http://xamarin.com/schemas/2014/forms"
                  xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                  x:Class="MasterPageDemo.MainPage"
                  xmlns:pages="clr-namespace:MasterPageDemo">
    <MasterDetailPage.Master>
        <pages:MasterPage x:Name="LocalMasterPage" />
    </MasterDetailPage.Master>
    <MasterDetailPage.Detail>
        <NavigationPage>
            <x:Arguments>
                <pages:DetailPage />
            </x:Arguments>
        </NavigationPage>
    </MasterDetailPage.Detail>
</MasterDetailPage>
```
