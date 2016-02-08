using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Media;

namespace Test1
{
    [Activity(MainLauncher = true)]
    public class MainActivity : Activity
    {

        private FrameLayout cover;
        private ToggleButton toggleMusic;
        private MediaPlayer player;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ActionBar.Hide();
            SetContentView(Resource.Layout.Main);
            cover = FindViewById<FrameLayout>(Resource.Id.titleScreen);
            player = MediaPlayer.Create(this, Resource.Raw.avril_14th);
            //player.Start();
            toggleMusic = FindViewById<ToggleButton>(Resource.Id.toggleMusic);
            

            cover.Click += delegate
            {
                StartActivity(typeof(Login));
            };

            toggleMusic.Click += (o, e) => {

                if (toggleMusic.Checked)
                {
                    player.Release();
                    toggleMusic = FindViewById<ToggleButton>(Resource.Id.toggleMusic);
                    player.Start();
                }
                else
                    player.Stop();
            };


        }


        


    }
}

