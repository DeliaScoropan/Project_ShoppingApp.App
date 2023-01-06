using Project_ShoppingApp;

namespace Project_ShoppingApp;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        this.BindingContext = new LoginViewModel(this.Navigation);
    }
}