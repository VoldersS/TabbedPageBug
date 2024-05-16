namespace TabbedPageBug.Views;

public partial class TabPageTwo : ContentPage
{
    public TabPageTwo()
    {
        InitializeComponent();
    }

    private async void Button2_Clicked(object sender, EventArgs e)
    {
        await Dispatcher.DispatchAsync(async () =>
        {
            await Navigation.PushModalAsync(new ModalPage());
            //await App.Current.MainPage.Navigation.PushModalAsync(new ModalPage());
        });
    }
}