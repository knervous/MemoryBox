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
            ActionBar.Hide();
            loginButton = FindViewById<Button>(Resource.Id.loginButton);

            var editText = FindViewById<EditText>(Resource.Id.loginInput);
            


            loginButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Boxes));
                StartActivity(intent);
            };

        }


    }
}