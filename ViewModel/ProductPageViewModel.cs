using Project_ShoppingApp.Models;
using Project_ShoppingApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project_ShoppingApp.ViewModel
{
    public class ProductPageViewModel
    {
        public ObservableCollection<Items> Items { get; set; }

        public ObservableCollection<Items> CartItems { get; set; }

        public Items SelectedItem { get; set; }

        public ICommand Itemclick { get; set; }
        public ICommand CartItemclick { get; set; }
        public ProductPageViewModel(INavigation navigation)
        {
            Items = new ObservableCollection<Items>
            {
                new Items
                {
                    Picture="casca.png",
                    Name = "Casca Ski",
                    Quantity = "1",
                    Price = "$99"
                },
                new Items
                {
                    Picture="clapari.png",
                    Name = "Clapari Ski",
                    Quantity = "1",
                    Price = "$89"
                },
                new Items
                {
                    Picture="costum.png",
                    Name = "Costum Ski",
                    Quantity = "1",
                    Price = "$85"
                },
                new Items
                {
                    Picture="snowboard.png",
                    Name = "Snowboard",
                    Quantity = "1",
                    Price = "$99"
                },
                new Items
                {
                    Picture="manusi.png",
                    Name = "Manusi Ski",
                    Quantity = "1",
                    Price = "$35"
                }
               /* new Items
                {
                    Picture="cagula.png",
                    Name = "Army Watch",
                    Quantity = "1",
                    Price = "$19"
                }*/
            };
            
            CartItems = new ObservableCollection<Items> { };
            Itemclick = new Command<Items>(executeitemclickcommand);
            CartItemclick = new Command<Items>(executeCartitemclickcommand);
            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeitemclickcommand(Items item)
        {
            this.SelectedItem = item;
            await navigation.PushModalAsync(new DetailPage(this));
        }

        async void executeCartitemclickcommand(Items item)
        {
            this.CartItems.Add(this.SelectedItem);
            await navigation.PushModalAsync(new CartPage(this));

        }
        }
    }

