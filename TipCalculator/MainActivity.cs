using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;

using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Android.Widget;

namespace TipCalculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : Activity
    {
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            EditText inputBill;
            Button calculateButton;
            TextView outputTip;
            TextView outputTotal;

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);



            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
           calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            calculateButton.Click += OnCalculateClick;
            
        }

        void OnCalculateClick(object sender, EventArgs e)
        {
            
        }
    }
}
