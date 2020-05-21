using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using LibVLCSharp;
using LibVLCSharp.Shared;


namespace JuniorDocApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        LibVLC _libvlc;
        private string videoUrl = "https://cdn.discordapp.com/attachments/446425869762691073/711991491903488081/7j02M0D.mp4";
        public MainPage()
        {
            InitializeComponent();
            Core.Initialize();
            _libvlc = new LibVLC();
            

            var media = new Media(_libvlc, videoUrl, FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media)
            {
                EnableHardwareDecoding = true
            };
            myVideo.MediaPlayer.Play(); //load vid
            myVideo.MediaPlayer.Pause(); //Start paused.

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void Button_Clicked_1(object sender, EventArgs e) => await Navigation.PushAsync(new Page2());

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}
