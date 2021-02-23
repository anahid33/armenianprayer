using armenianprayer.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace armenianprayer.Views
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