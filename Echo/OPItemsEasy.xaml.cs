using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Echo
{
    public partial class OPItemsEasy : ContentPage
    {
        public OPItemsEasy()
        {
            InitializeComponent();
            Item1img.IsVisible = false;
            Item1txt.IsVisible = false;
            Item2img.IsVisible = false;
            Item2txt.IsVisible = false;
            Item3img.IsVisible = false;
            Item3txt.IsVisible = false;
            countdown_btn.IsVisible = false;
            
            
        }

        private async void StartClicked(object sender, EventArgs e)
        {

            Item1img.IsVisible = true;
            Item1txt.IsVisible = true;
            Item2img.IsVisible = true;
            Item2txt.IsVisible = true;
            Item3img.IsVisible = true;
            Item3txt.IsVisible = true;
            countdown_btn.IsVisible = true;
            StartBtn.IsVisible = false;

            await Task.Run(async () =>
            {
                for (int i = 10; i >= 0; i--)
                {
                    //if your code requires UI then wrap it in BeginInvokeOnMainThread
                    //otherwise just run your code
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        countdown_btn.Text = $"{i}";
                        countdown_btn.FontSize = 22;
                    });
                    await Task.Delay(1500);
                }
            });
            countdown_btn.FontSize = 15;
            countdown_btn.Text = "Done";
            //Automatically moves to next page
            Navigation.PushAsync(new OPItemsP2Easy());
        }

        void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
