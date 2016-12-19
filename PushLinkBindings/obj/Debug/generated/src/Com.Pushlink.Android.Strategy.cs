using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pushlink.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']"
	[global::Android.Runtime.Register ("com/pushlink/android/Strategy", DoNotGenerateAcw=true)]
	public abstract partial class Strategy : global::Java.Lang.Object {

		protected Strategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[global::Android.Runtime.Register ("com/pushlink/android/Strategy", DoNotGenerateAcw=true)]
	internal partial class StrategyInvoker : Strategy {

		public StrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrategyInvoker); }
		}

	}

}
