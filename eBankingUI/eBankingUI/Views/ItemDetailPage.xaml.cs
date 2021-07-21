using eBankingUI.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eBankingUI.Views
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