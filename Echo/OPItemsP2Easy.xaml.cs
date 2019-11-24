using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Echo
{
    public partial class OPItemsP2Easy : ContentPage
    {
        public OPItemsP2Easy()
        {
            InitializeComponent();
        }

        void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        void CheckClicked(object sender, EventArgs e)
        {
         
        }

        void ItemOneClicked(object sender, EventArgs e)
        {
            if (ItemOneBox.IsVisible==true)
            {
                ItemOneBox.IsVisible = false;
            }
            else {
                ItemOneBox.IsVisible = true;
            }

        }

        void ItemTwoClicked(object sender, EventArgs e)
        {
            if (ItemTwoBox.IsVisible == true)
            {
                ItemTwoBox.IsVisible = false;
            }
            else
            {
                ItemTwoBox.IsVisible = true;
            }
        }

        void ItemThreeClicked(object sender, EventArgs e)
        {
            if (ItemThreeBox.IsVisible == true)
            {
                ItemThreeBox.IsVisible = false;
            }
            else
            {
                ItemThreeBox.IsVisible = true;
            }
        }

        void ItemFourClicked(object sender, EventArgs e)
        {
            if (ItemFourBox.IsVisible == true)
            {
                ItemFourBox.IsVisible = false;
            }
            else
            {
                ItemFourBox.IsVisible = true;
            }
        }

    }
}
