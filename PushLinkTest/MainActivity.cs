using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Com.Pushlink.Android;

namespace PushLinkTest
{
    [Activity(Label = "PushLinkTest", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.NoTitleBar")]
    public class MainActivity : Activity
    {
        private WebView _myWebView;
        private Guid _erfassungsFormular = new Guid("2326c942-5ee7-435d-9fb4-2abf38f6febd");
        private static Bundle _savedInstance;

        protected override void OnCreate(Bundle inBundle)
        {
            base.OnCreate(inBundle);

            SetContentView(Resource.Layout.Main);
            _myWebView = FindViewById<WebView>(Resource.Id.LocalWebView);
            if (_savedInstance != null)
            {
                _myWebView.RestoreState(_savedInstance);
                _myWebView.SetWebViewClient(new WebViewClient());
                _myWebView.Settings.JavaScriptEnabled = true;
                _savedInstance = null;
            }
            else
            {
                _myWebView.SetWebViewClient(new WebViewClient());

                _myWebView.Settings.JavaScriptEnabled = true;
                _myWebView.LoadUrl("https://google.com");
            }

        }

        public override void OnBackPressed()
        {
            if (_myWebView.CanGoBack())
            {
                _myWebView.GoBack();
            }
            //base.OnBackPressed();
        }

        protected override void OnPause()
        {
            base.OnPause();
            if (_savedInstance == null) { _savedInstance = new Bundle(); }
            _myWebView.SaveState(_savedInstance);
        }

        protected override void OnStop()
        {
            base.OnStop();
            if (_savedInstance == null) { _savedInstance = new Bundle(); }
            _myWebView.SaveState(_savedInstance);
        }

        protected override void OnResume()
        {
            base.OnResume();
            PushLink.SetCurrentActivity(this);
        }
    }
}

