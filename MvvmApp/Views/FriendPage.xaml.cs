using MvvmApp.ViewModels;

namespace MvvmApp.Views;

public partial class FriendPage : ContentPage
{
    public FriendViewModel ViewModel { get; private set; }
    public FriendPage(FriendViewModel vm)
    {
        InitializeComponent();
        ViewModel = vm;
        this.BindingContext = ViewModel;
    }
}