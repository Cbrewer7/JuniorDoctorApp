using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MediaManager.Forms;
using MediaManager;
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
        private string videoUrl = "https://sec.ch9.ms/ch9/e68c/690eebb1-797a-40ef-a841-c63dded4e68c/Cognitive-Services-Emotion_high.mp4";
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
            myVideo.MediaPlayer.Play();


        }

        



    }
}
