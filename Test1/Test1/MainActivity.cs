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


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ActionBar.Hide();
            SetContentView(Resource.Layout.Main);
            cover = FindViewById<FrameLayout>(Resource.Id.titleScreen);
            MediaPlayer player = MediaPlayer.Create(this, Resource.Raw.avril_14th);
            player.Start();

            cover.Click += delegate
            {
                StartActivity(typeof(Login));
            };
            

        }


        


    }
}

