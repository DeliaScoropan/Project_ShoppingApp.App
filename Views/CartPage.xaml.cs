using Project_ShoppingApp.ViewModel;

namespace Project_ShoppingApp.Views;

public partial class CartPage : ContentPage
{
    public CartPage(ProductPageViewModel productPageViewModel)
    {
        InitializeComponent();
        BindingContext = productPageViewModel;
    }
}