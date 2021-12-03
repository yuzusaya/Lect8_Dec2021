using Lect8V2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lect8V2.Views
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