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

namespace MemoryBox
{
    [Activity()]
    public class Boxes : Activity
    {
        private Button nextPage;
        private List<string> boxes;
        private ListView boxListView;
        private ArrayAdapter<string> listAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ActionBar.Hide();
            SetContentView(Resource.Layout.Boxes);
            nextPage = FindViewById<Button>(Resource.Id.toMemories);
            nextPage.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Memories));
                StartActivity(intent);
            };
            boxes = new List<string>();
            boxListView = FindViewById<ListView>(Resource.Id.memListView);

            boxes.Add("Box 1");
            boxes.Add("Box 2");
            boxes.Add("Box 3");

            listAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, boxes);
            boxListView.Adapter = listAdapter;

        }

        //protected override void OnListItemClick(ListView l, View v, int position, long id)
        //{
        //    var t = boxes[position];
        //    Android.Widget.Toast.MakeText(this, t, Android.Widget.ToastLength.Short).Show();
        //}
    }

    public class BoxList : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ActionBar.Hide();

        }
    }
}