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
    [Activity(Label = "Memories")]
    public class Memories : Activity, View.IOnTouchListener
    {
        private List<Button> voiceButtons;
        private Button testButton;
        private FrameLayout fl;
        private float _viewX;
        private float _viewY;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Memories);
            //voiceButtons.Add(new Button(this));
            //voiceButtons[0].SetBackgroundResource(Resource.Drawable.voiceMem);
            //voiceButtons[0].SetHeight(50);
            //voiceButtons[0].SetWidth(50);

            testButton = new Button(this);
            
            FrameLayout.LayoutParams prm = new FrameLayout.LayoutParams(FrameLayout.LayoutParams.WrapContent, FrameLayout.LayoutParams.WrapContent);
            fl = FindViewById<FrameLayout>(Resource.Id.memFrame);
            fl.AddView(testButton, prm);
            testButton.SetBackgroundResource(Resource.Drawable.voice_mem);

            testButton.SetOnTouchListener(this);
            

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