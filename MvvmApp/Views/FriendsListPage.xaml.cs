using MvvmApp.ViewModels;

namespace MvvmApp.Views;

public partial class FriendsListPage : ContentPage
{
    public FriendsListPage()
    {
        InitializeComponent();
        BindingContext = new FriendsListViewModel() { Navigation = this.Navigation };
    }
}