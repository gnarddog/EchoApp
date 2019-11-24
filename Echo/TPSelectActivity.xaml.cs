using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Echo.iOS
{
    public partial class TPSelectActivity : ContentPage
    {
        public TPSelectActivity()
        {
            InitializeComponent();
        }

        void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        void ItemsClicked(object sender, EventArgs e)
        {
            switch (Options.difficulty)
            {
                case "Easy":
                    Navigation.PushAsync(new OPItemsEasy());
                    Options.imgdif = Options.easydif;
                    break;
                case "Medium":
                    Navigation.PushAsync(new OPItemsMedium());
                    Options.imgdif = Options.mediumdif;
                    break;
                case "Hard":
                    Navigation.PushAsync(new OPItemsHard());
                    Options.imgdif = Options.harddif;
                    break;
            }
        }
        void NumbersClicked(object sender, EventArgs e)
        {

        }
        void TimesTablesClicked(object sender, EventArgs e)
        {

        }
    }
}
