# MasterDetailPageDemo
This project will show you how to set up a simple MasterDetailPage in Xamarin.

## Create the MasterDetailPage
Create a new Cross-Platform App (Xamarin.Forms) project. 
Then navigate to the MainPage.xaml and set the ```<ContentPage>``` tag to ```<MasterDetailPage>```. <br />
Example:
```xaml
<MasterDetailPage xmlns="http://xamarin.com/schemas/2014/forms"
                  xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                  x:Class="MasterPageDemo.MainPage"
                  xmlns:pages="clr-namespace:MasterPageDemo">
             
             ....
             ....
</MasterDetailPage>
``` 
Next you need to create a new ContentPage which will be your detail page.
A detail page presents details about items on the master page. <br />
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
Next you need to create a new ContentPage for your master page.
This page shows a list of items.
Create a class for your menu items and bind them as an ItemSource in the ListView of your MasterPage.xaml.
You will find an example of a master page in this project [MasterPage](MasterDetailPageDemo/src/MasterDemo/MasterDemo/MasterPage.xaml). 
The next step is to create a view model for your MasterPage, containing an ObservableCollection of your menu items.
The last step is to declare the MasterPage and the DetailPage in your MainPage.xaml as follows:
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
