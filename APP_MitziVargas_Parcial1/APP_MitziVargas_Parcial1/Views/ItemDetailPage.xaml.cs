using APP_MitziVargas_Parcial1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace APP_MitziVargas_Parcial1.Views
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