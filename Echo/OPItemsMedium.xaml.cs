using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Echo
{
    public partial class OPItemsMedium : ContentPage
    {
        public OPItemsMedium()
        {
            InitializeComponent();
        }

        void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
