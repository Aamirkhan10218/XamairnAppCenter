using System.ComponentModel;
using Xamarin.Forms;
using XamairnAppCenter.ViewModels;

namespace XamairnAppCenter.Views
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