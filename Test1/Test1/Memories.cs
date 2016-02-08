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
using Java.Util;
using Android.Graphics.Drawables.Shapes;

namespace Test1
{
    [Activity()]
    public class Memories : Activity, View.IOnTouchListener
    {
        
        private Button testButton;
        private Button testButton2;
        private Button testButton3;
        private FrameLayout fl;
        private float _viewX;
        private float _viewY;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ActionBar.Hide();
            SetContentView(Resource.Layout.Memories);
            

            testButton = new Button(this);
            testButton2 = new Button(this);
            testButton3 = new Button(this);

            FrameLayout.LayoutParams prm = new FrameLayout.LayoutParams(FrameLayout.LayoutParams.WrapContent, FrameLayout.LayoutParams.WrapContent);
            prm.Height = 175;
            prm.Width = 175;
            fl = FindViewById<FrameLayout>(Resource.Id.memFrame);
            fl.AddView(testButton, prm);
            fl.AddView(testButton2, prm);
            fl.AddView(testButton3, prm);

            testButton.SetBackgroundResource(Resource.Drawable.voice_mem);
            testButton2.SetBackgroundResource(Resource.Drawable.text_mem);
            testButton3.SetBackgroundResource(Resource.Drawable.vid_mem);

            testButton.SetOnTouchListener(this);
            testButton2.SetOnTouchListener(this);
            testButton3.SetOnTouchListener(this);
            

        }

        public bool OnTouch(View v, MotionEvent e)
        {
            switch (e.Action)
            {
                case MotionEventActions.Down:
                    _viewX = v.GetX() - e.RawX;
                    _viewY = v.GetY() - e.RawY;

                    break;
                case MotionEventActions.Move:
                    //var left = (int)(e.RawX - _viewX);
                    //var right = (int)(left + v.Width);
                    //v.Layout(left, v.Top, right, v.Bottom);
                    //break;
                    v.Animate()
                        .X(e.RawX + _viewX)
                       .Y(e.RawY + _viewY)
                       .SetDuration(0)
                       .Start();
                    break;
                default: return false;

            }
            return true;
        }
    }
}