namespace TabbedPageBug.Views;

public partial class ModalPage : ContentPage
{
    public ModalPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Dispatcher.DispatchAsync(async () =>
        {
            await Task.Delay(2500);
            await Navigation.PopModalAsync();
            //await App.Current.MainPage.Navigation.PopModalAsync();
        });
    }
}