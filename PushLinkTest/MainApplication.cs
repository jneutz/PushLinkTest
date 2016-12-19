using System;
using Android.App;
using Android.Runtime;
using Com.Pushlink.Android;

namespace PushLinkTest
{
    [Application]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            PushLink.Start(this, 2130837504, "9lrbrs8aktvp528o", "unique_dev0");

            StatusBarStrategy sbs = (StatusBarStrategy)PushLink.CurrentStrategy;
            sbs.StatusBarTitle = ("Hello, there is a new version");
            sbs.StatusBarDescription = ("Click to be happy");

            //Changing strategy
            PushLink.SetCurrentStrategy(StrategyEnum.FriendlyPopup);

            //Modifying new strategy
            FriendlyPopUpStrategy fps = (FriendlyPopUpStrategy)PushLink.CurrentStrategy;
            fps.PopUpMessage = ("New version available");
            fps.NotNowButton = ("No, thanks!");
            fps.UpdateButton = ("Ok, lets go");
            fps.ReminderTimeInSeconds = (Java.Lang.Integer)3600; //one hour
        }
    }
}