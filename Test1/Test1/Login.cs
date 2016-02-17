using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Views;
using Android.Content;

namespace MemoryBox
{
    [Activity()]
    public class Login : Activity
    {
        private Button loginButton;
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ActionBar.Hide();
            SetContentView(Resource.Layout.Login);

            loginButton = FindViewById<Button>(Resource.Id.loginButton);


            loginButton.Click += (sender, e) =>
            {
                StartActivity(typeof(Boxes));
            };

        }


    }
}