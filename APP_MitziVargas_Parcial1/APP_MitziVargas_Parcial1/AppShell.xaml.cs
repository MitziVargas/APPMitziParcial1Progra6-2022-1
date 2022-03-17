using APP_MitziVargas_Parcial1.ViewModels;
using APP_MitziVargas_Parcial1.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace APP_MitziVargas_Parcial1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
