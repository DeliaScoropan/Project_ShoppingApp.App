using Project_ShoppingApp.ViewModel;

namespace Project_ShoppingApp.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        this.BindingContext = new LoginViewModel(this.Navigation);
    }
}