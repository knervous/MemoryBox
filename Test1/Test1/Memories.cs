using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace MemoryBox
{
    [Activity()]
    public class Memories : Activity, View.IOnTouchListener
    {
        

        private FrameLayout fl;
        private float _viewX;
        private float _viewY;
        private List<Button> voiceButtons;
        private List<Button> textButtons;
        private List<Button> vidButtons;
        private List<FrameLayout.LayoutParams> prmList;
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ActionBar.Hide();
            SetContentView(Resource.Layout.Memories);
            prmList = new List<FrameLayout.LayoutParams>();
            fl = FindViewById<FrameLayout>(Resource.Id.memFrame);

            voiceButtons = new List<Button>();
            textButtons = new List<Button>();
            vidButtons = new List<Button>();

            var randInt = (int)RandomNumber(1, 5);

            CreateButtons(randInt);
            

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

        private int RandomNumber(int min, int max)
        {
            System.Random random = new System.Random();
            return random.Next(min, max);
        }

        public void CreateButtons(int number)
        {
            int dimensionRand = 0;
            for (int i = 0; i < number; i++)
            {
                prmList.Add(new FrameLayout.LayoutParams(FrameLayout.LayoutParams.WrapContent, FrameLayout.LayoutParams.WrapContent));

                voiceButtons.Add(new Button(this));
                textButtons.Add(new Button(this));
                vidButtons.Add(new Button(this));

                dimensionRand = RandomNumber(100, 200);

                prmList[i].Height = dimensionRand;
                prmList[i].Width = dimensionRand;

                fl.AddView(voiceButtons[i], prmList[i]);
                fl.AddView(textButtons[i], prmList[i]);
                fl.AddView(vidButtons[i], prmList[i]);

                voiceButtons[i].SetBackgroundResource(Resource.Drawable.voice_mem);
                textButtons[i].SetBackgroundResource(Resource.Drawable.text_mem);
                vidButtons[i].SetBackgroundResource(Resource.Drawable.vid_mem);

                voiceButtons[i].SetOnTouchListener(this);
                textButtons[i].SetOnTouchListener(this);
                vidButtons[i].SetOnTouchListener(this);

            }
        }
    }
}