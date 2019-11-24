using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Echo
{
    public partial class OPSelectDifficulty : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        public OPSelectDifficulty()
        {
            InitializeComponent();
        }

        void BackClicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
        void DifficultyClicked(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;

            Options.difficulty = btn.ClassId;
            if (Options.numberofplayers == "1") {
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
            }else if (Options.numberofplayers == "2")
            {
                switch (Options.difficulty)
                {
                    case "Easy":
                        Navigation.PushAsync(new TPSelectActEasy());
                        Options.imgdif = Options.easydif;
                        break;
                    case "Medium":
                        Navigation.PushAsync(new TPSelectActMedium());
                        Options.imgdif = Options.mediumdif;
                        break;
                    case "Hard":
                        Navigation.PushAsync(new TPSelectActHard());
                        Options.imgdif = Options.harddif;
                        break;
                }
            }
            //DisplayAlert("", Options.difficulty, "Okay");
            //Navigation.PushAsync(new OPSelectActivity());
        }
    }
}
