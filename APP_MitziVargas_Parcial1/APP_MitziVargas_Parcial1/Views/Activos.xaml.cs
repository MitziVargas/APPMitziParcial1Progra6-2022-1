using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APP_MitziVargas_Parcial1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activos : ContentPage
    {
        public Activos()
        {
            InitializeComponent();
        }

        private async void CmdLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}