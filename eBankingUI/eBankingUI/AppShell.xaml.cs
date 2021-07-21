using eBankingUI.ViewModels;
using eBankingUI.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace eBankingUI
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
