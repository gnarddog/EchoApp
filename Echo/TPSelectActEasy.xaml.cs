using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Echo
{
    public partial class TPSelectActEasy : ContentPage
    {
        public TPSelectActEasy()
        {
            InitializeComponent();
        }

        void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        void ItemsClicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new TPItemsPage1());
        }
        void NumbersClicked(object sender, EventArgs e)
        {

        }
        void TimesTablesClicked(object sender, EventArgs e)
        {

        }
    }
}
