using Project_ShoppingApp;

namespace Project_ShoppingApp;

public partial class DetailPage : ContentPage
{
    public DetailPage(ProductPageViewModel item)
    {
        InitializeComponent();
        BindingContext = item;
    }
}