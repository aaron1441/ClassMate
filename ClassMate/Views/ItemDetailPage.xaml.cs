using ClassMate.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ClassMate.Views
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