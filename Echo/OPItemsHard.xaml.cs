using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Echo
{
    public partial class OPItemsHard : ContentPage
    {
        public OPItemsHard()
        {
            InitializeComponent();
        }

        void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
