using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Views;
using Android.Content;

namespace Test1
{
    [Activity(Label = "test page")]
    public class Login : Activity
    {
        private Button loginButton;
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Login);
            loginButton = FindViewById<Button>(Resource.Id.loginButton);

            loginButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Boxes));
                StartActivity(intent);
            };

        }


    }
}