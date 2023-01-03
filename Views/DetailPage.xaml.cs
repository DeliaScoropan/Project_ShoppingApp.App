using Project_ShoppingApp.ViewModel;

namespace Project_ShoppingApp.Views;

public partial class DetailPage : ContentPage
{
    public DetailPage(ProductPageViewModel item)
    {
        InitializeComponent();
        BindingContext = item;
    }
}