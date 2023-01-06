using Project_ShoppingApp;

namespace Project_ShoppingApp;

public partial class ProductPage : ContentPage
{
    ProductPageViewModel productPageViewModel;
    public ProductPage()
    {
        InitializeComponent();
        productPageViewModel = new ProductPageViewModel(this.Navigation);
        BindingContext = productPageViewModel;
    }
}