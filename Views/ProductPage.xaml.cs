using Project_ShoppingApp.ViewModel;

namespace Project_ShoppingApp.Views;

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