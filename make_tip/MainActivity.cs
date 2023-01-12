using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace make_tip
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button btnmood;
        private Button btnservice;
        private Button btnfood;
        private EditText etprice;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            InitializaViews();

        }

        private void InitializaViews()
        {
            btnfood = FindViewById<Button>(Resource.Id.btnfood);
            btnservice = FindViewById<Button>(Resource.Id.btnservice);
            btnmood = FindViewById<Button>(Resource.Id.btnmood);
            etprice = FindViewById<EditText>(Resource.Id.etprice);
            btnfood.Click += Btnfood_Click;

        }

        private void Btnfood_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this,typeof())
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}