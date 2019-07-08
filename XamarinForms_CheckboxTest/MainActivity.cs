using System;
using Android.App;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V7.App;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinForms_CheckboxTest_Shared;

namespace XamarinForms_CheckboxTest
{
    [Activity(Label = "XamarinForms_CheckboxTest", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Forms.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.Main);

            //error is thrown here:
            //CheckBox only works with Theme.AppCompat theme (or descendant)
            Android.Support.V4.App.Fragment testPage = new TestPage().CreateSupportFragment(this);

            Android.Widget.Button button = FindViewById<Android.Widget.Button>(Resource.Id.testButton);

            button.Click += OnTestButtonClicked;


            void OnTestButtonClicked(object sender, EventArgs e)
            {
                SupportFragmentManager
                    .BeginTransaction()
                    .Replace(Resource.Id.frameLayout1, testPage);
            }
        }
    }
}

