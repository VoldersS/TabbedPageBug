namespace TabbedPageBug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Doesn't work
            MainPage = new MainTabbedPage();

            //Works
            //MainPage = new MainShellTabbedPage();
        }
    }
}
