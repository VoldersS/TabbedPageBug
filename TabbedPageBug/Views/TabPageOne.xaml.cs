namespace TabbedPageBug.Views;

public partial class TabPageOne : ContentPage
{
    public TabPageOne()
    {
        InitializeComponent();
    }

    private async void Button1_Clicked(object sender, EventArgs e)
    {
        await Dispatcher.DispatchAsync(async () =>
        {
            await Navigation.PushModalAsync(new ModalPage());
            //await App.Current.MainPage.Navigation.PushModalAsync(new ModalPage());
        });
    }
}