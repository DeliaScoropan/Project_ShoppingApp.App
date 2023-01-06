using Project_ShoppingApp;

namespace Project_ShoppingApp;

public partial class CartPage : ContentPage
{
    public CartPage(ProductPageViewModel productPageViewModel)
    {
        InitializeComponent();
        BindingContext = productPageViewModel;
    }
}