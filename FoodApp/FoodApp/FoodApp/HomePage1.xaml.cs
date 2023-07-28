using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage1 : TabbedPage
    {
        public HomePage1()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<ListItem> listItems = new List<ListItem>();
            ListItem listItem = new ListItem() { Title = "Pav Baji", Description = "dhon Pav Ek vada called vadapav", Price = "Rs.250", Percentage = "50%" };
            ListItem listItem1 = new ListItem() { Title = "Panner Masala", Description = "panner is curry with masala called panner masala", Price = "Rs.150", Percentage = "50%" };
            ListItem listItem2 = new ListItem() { Title = "Biryani", Description = "Biryani is a mixed rice dish originating among the Muslims of South Asia.", Price = "Rs.250", Percentage = "50%" };
            ListItem listItem3 = new ListItem() { Title = "Dosa", Description = "A dosa, also called dosai, is a thin pancake in South Indian cuisine", Price = "Rs.50", Percentage = "50%" };
            listItems.Add(listItem);
            listItems.Add(listItem1);
            listItems.Add(listItem2);
            listItems.Add(listItem3);
            collectionList.ItemsSource = listItems;
        }
    }
}