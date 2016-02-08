using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Test1
{
    [Activity(Label = "Activity2")]
    public class Boxes : Activity
    {
        private Button nextPage;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Boxes);
            nextPage = FindViewById<Button>(Resource.Id.toMemories);
            nextPage.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Memories));
                StartActivity(intent);
            };
        }
    }
}