using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Echo
{
    public partial class OPSelectActivity : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public OPSelectActivity()
        {
            InitializeComponent();
            difficultyimage.Image = Options.imgdif;
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
                    Navigation.PushAsync(new OPSelectActEasy());
                    Options.imgdif = Options.easydif;
                    break;
                case "Medium":
                    Navigation.PushAsync(new OPSelectActMedium());
                    Options.imgdif = Options.mediumdif;
                    break;
                case "Hard":
                    Navigation.PushAsync(new OPSelectActHard());
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
