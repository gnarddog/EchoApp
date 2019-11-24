using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Echo
{
    public partial class MainPage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        public MainPage()
        {
            InitializeComponent();
        }

        void OnePlayerBtn_Clicked(object sender, System.EventArgs e)
        {
            Options.numberofplayers = "1";
            Navigation.PushAsync(new OPSelectDifficulty());
        }

        void TwoPlayerBtn_Clicked(object sender, System.EventArgs e)
        {
            Options.numberofplayers = "2";
            Navigation.PushAsync(new OPSelectDifficulty());
        }

    }
}
