using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Test1
{
    [Activity(Label = "Test1", MainLauncher = true)]
    public class MainActivity : Activity
    {

        private FrameLayout cover;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            cover = FindViewById<FrameLayout>(Resource.Id.titleScreen);
            cover.Click += delegate
            {
                StartActivity(typeof(Login));
            };
            

        }


        


    }
}

