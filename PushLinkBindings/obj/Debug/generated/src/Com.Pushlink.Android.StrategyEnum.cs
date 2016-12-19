using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pushlink.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pushlink.android']/class[@name='StrategyEnum']"
	[global::Android.Runtime.Register ("com/pushlink/android/StrategyEnum", DoNotGenerateAcw=true)]
	public sealed partial class StrategyEnum : global::Java.Lang.Enum {


		static IntPtr ANNOYING_POPUP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='StrategyEnum']/field[@name='ANNOYING_POPUP']"
		[Register ("ANNOYING_POPUP")]
		public static global::Com.Pushlink.Android.StrategyEnum AnnoyingPopup {
			get {
				if (ANNOYING_POPUP_jfieldId == IntPtr.Zero)
					ANNOYING_POPUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANNOYING_POPUP", "Lcom/pushlink/android/StrategyEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANNOYING_POPUP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.StrategyEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CUSTOM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='StrategyEnum']/field[@name='CUSTOM']"
		[Register ("CUSTOM")]
		public static global::Com.Pushlink.Android.StrategyEnum Custom {
			get {
				if (CUSTOM_jfieldId == IntPtr.Zero)
					CUSTOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM", "Lcom/pushlink/android/StrategyEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.StrategyEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FRIENDLY_POPUP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='StrategyEnum']/field[@name='FRIENDLY_POPUP']"
		[Register ("FRIENDLY_POPUP")]
		public static global::Com.Pushlink.Android.StrategyEnum FriendlyPopup {
			get {
				if (FRIENDLY_POPUP_jfieldId == IntPtr.Zero)
					FRIENDLY_POPUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRIENDLY_POPUP", "Lcom/pushlink/android/StrategyEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRIENDLY_POPUP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.StrategyEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NINJA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='StrategyEnum']/field[@name='NINJA']"
		[Register ("NINJA")]
		public static global::Com.Pushlink.Android.StrategyEnum Ninja {
			get {
				if (NINJA_jfieldId == IntPtr.Zero)
					NINJA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NINJA", "Lcom/pushlink/android/StrategyEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NINJA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.StrategyEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STATUS_BAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='StrategyEnum']/field[@name='STATUS_BAR']"
		[Register ("STATUS_BAR")]
		public static global::Com.Pushlink.Android.StrategyEnum StatusBar {
			get {
				if (STATUS_BAR_jfieldId == IntPtr.Zero)
					STATUS_BAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STATUS_BAR", "Lcom/pushlink/android/StrategyEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STATUS_BAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.StrategyEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pushlink/android/StrategyEnum", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrategyEnum); }
		}

		internal StrategyEnum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StrategyEnum']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/pushlink/android/StrategyEnum;", "")]
		public static unsafe global::Com.Pushlink.Android.StrategyEnum ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/pushlink/android/StrategyEnum;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Pushlink.Android.StrategyEnum __ret = global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.StrategyEnum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StrategyEnum']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/pushlink/android/StrategyEnum;", "")]
		public static unsafe global::Com.Pushlink.Android.StrategyEnum[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/pushlink/android/StrategyEnum;");
			try {
				return (global::Com.Pushlink.Android.StrategyEnum[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Pushlink.Android.StrategyEnum));
			} finally {
			}
		}

	}
}
