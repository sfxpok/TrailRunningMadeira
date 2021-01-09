using System.ComponentModel;
using TrailRunningMadeira.ViewModels;
using Xamarin.Forms;

namespace TrailRunningMadeira.Views
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