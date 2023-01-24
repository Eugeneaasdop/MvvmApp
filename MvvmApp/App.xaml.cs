using MvvmApp.Views;

namespace MvvmApp;

public partial class App : Application
{
    public App()
    {
        MainPage = new NavigationPage(new FriendsListPage());
    }

    protected override void OnStart()
    { }

    protected override void OnSleep()
    { }

    protected override void OnResume()
    { }
}
