using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace MemoryBox
{
    [Activity(MainLauncher = true)]
    public class MainActivity : Activity
    {

        private FrameLayout cover;
        private ToggleButton toggleMusic;
        private MediaPlayer player;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ActionBar.Hide();
            SetContentView(Resource.Layout.Main);
            cover = FindViewById<FrameLayout>(Resource.Id.titleScreen);
            player = MediaPlayer.Create(this, Resource.Raw.avril_14th);
            toggleMusic = FindViewById<ToggleButton>(Resource.Id.toggleMusic);
            
            

            cover.Click += delegate
            {
                StartActivity(typeof(Login));
            };

            toggleMusic.Click += (o, e) => {

                if (toggleMusic.Checked)
                {
                    player.Release();
                    player = MediaPlayer.Create(this, Resource.Raw.avril_14th);
                    player.Start();
                    player.Looping = true;
                }
                else
                    player.Stop();
            };


        }

        public override void OnBackPressed()
        {
            Finish();
            Process.KillProcess(Process.MyPid());
        }





    }
}

