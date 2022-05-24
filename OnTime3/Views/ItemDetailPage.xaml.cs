using System.ComponentModel;
using OnTime3.ViewModels;
using Xamarin.Forms;

namespace OnTime3.Views
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