using RPGcharacters.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RPGcharacters.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}