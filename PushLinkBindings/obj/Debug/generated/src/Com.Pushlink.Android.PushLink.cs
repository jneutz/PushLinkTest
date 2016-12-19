using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pushlink.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']"
	[global::Android.Runtime.Register ("com/pushlink/android/PushLink", DoNotGenerateAcw=true)]
	public sealed partial class PushLink : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pushlink/android/PushLink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushLink); }
		}

		internal PushLink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCurrentStrategy;
		public static unsafe global::Com.Pushlink.Android.Strategy CurrentStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='getCurrentStrategy' and count(parameter)=0]"
			[Register ("getCurrentStrategy", "()Lcom/pushlink/android/Strategy;", "GetGetCurrentStrategyHandler")]
			get {
				if (id_getCurrentStrategy == IntPtr.Zero)
					id_getCurrentStrategy = JNIEnv.GetStaticMethodID (class_ref, "getCurrentStrategy", "()Lcom/pushlink/android/Strategy;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentStrategy), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_hasPendingUpdate;
		public static unsafe bool HasPendingUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='hasPendingUpdate' and count(parameter)=0]"
			[Register ("hasPendingUpdate", "()Z", "GetHasPendingUpdateHandler")]
			get {
				if (id_hasPendingUpdate == IntPtr.Zero)
					id_hasPendingUpdate = JNIEnv.GetStaticMethodID (class_ref, "hasPendingUpdate", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasPendingUpdate);
				} finally {
				}
			}
		}

		static IntPtr id_hasPengingUpdate;
		[Obsolete (@"deprecated")]
		public static unsafe bool HasPengingUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='hasPengingUpdate' and count(parameter)=0]"
			[Register ("hasPengingUpdate", "()Z", "GetHasPengingUpdateHandler")]
			get {
				if (id_hasPengingUpdate == IntPtr.Zero)
					id_hasPengingUpdate = JNIEnv.GetStaticMethodID (class_ref, "hasPengingUpdate", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasPengingUpdate);
				} finally {
				}
			}
		}

		static IntPtr id_addExceptionMetadata_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='addExceptionMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addExceptionMetadata", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AddExceptionMetadata (string p0, string p1)
		{
			if (id_addExceptionMetadata_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addExceptionMetadata_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addExceptionMetadata", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addExceptionMetadata_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_addMetadata_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='addMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMetadata", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AddMetadata (string p0, string p1)
		{
			if (id_addMetadata_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addMetadata_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addMetadata", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addMetadata_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_disableExceptionNotification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='disableExceptionNotification' and count(parameter)=0]"
		[Register ("disableExceptionNotification", "()V", "")]
		public static unsafe void DisableExceptionNotification ()
		{
			if (id_disableExceptionNotification == IntPtr.Zero)
				id_disableExceptionNotification = JNIEnv.GetStaticMethodID (class_ref, "disableExceptionNotification", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disableExceptionNotification);
			} finally {
			}
		}

		static IntPtr id_enableExceptionNotification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='enableExceptionNotification' and count(parameter)=0]"
		[Register ("enableExceptionNotification", "()V", "")]
		public static unsafe void EnableExceptionNotification ()
		{
			if (id_enableExceptionNotification == IntPtr.Zero)
				id_enableExceptionNotification = JNIEnv.GetStaticMethodID (class_ref, "enableExceptionNotification", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableExceptionNotification);
			} finally {
			}
		}

		static IntPtr id_idle_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='idle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("idle", "(Z)V", "")]
		public static unsafe void Idle (bool p0)
		{
			if (id_idle_Z == IntPtr.Zero)
				id_idle_Z = JNIEnv.GetStaticMethodID (class_ref, "idle", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idle_Z, __args);
			} finally {
			}
		}

		static IntPtr id_sendAsyncException_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='sendAsyncException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("sendAsyncException", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void SendAsyncException (global::Java.Lang.Throwable p0)
		{
			if (id_sendAsyncException_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_sendAsyncException_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "sendAsyncException", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendAsyncException_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_sendAsyncException_Ljava_lang_Throwable_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='sendAsyncException' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("sendAsyncException", "(Ljava/lang/Throwable;Ljava/util/Map;)V", "")]
		public static unsafe void SendAsyncException (global::Java.Lang.Throwable p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_sendAsyncException_Ljava_lang_Throwable_Ljava_util_Map_ == IntPtr.Zero)
				id_sendAsyncException_Ljava_lang_Throwable_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "sendAsyncException", "(Ljava/lang/Throwable;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendAsyncException_Ljava_lang_Throwable_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setCurrentActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='setCurrentActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setCurrentActivity", "(Landroid/app/Activity;)V", "")]
		public static unsafe void SetCurrentActivity (global::Android.App.Activity p0)
		{
			if (id_setCurrentActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_setCurrentActivity_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "setCurrentActivity", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrentActivity_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_setCurrentStrategy_Lcom_pushlink_android_StrategyEnum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='setCurrentStrategy' and count(parameter)=1 and parameter[1][@type='com.pushlink.android.StrategyEnum']]"
		[Register ("setCurrentStrategy", "(Lcom/pushlink/android/StrategyEnum;)V", "")]
		public static unsafe void SetCurrentStrategy (global::Com.Pushlink.Android.StrategyEnum p0)
		{
			if (id_setCurrentStrategy_Lcom_pushlink_android_StrategyEnum_ == IntPtr.Zero)
				id_setCurrentStrategy_Lcom_pushlink_android_StrategyEnum_ = JNIEnv.GetStaticMethodID (class_ref, "setCurrentStrategy", "(Lcom/pushlink/android/StrategyEnum;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrentStrategy_Lcom_pushlink_android_StrategyEnum_, __args);
			} finally {
			}
		}

		static IntPtr id_setMaxExceptionQueueSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='setMaxExceptionQueueSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxExceptionQueueSize", "(I)V", "")]
		public static unsafe void SetMaxExceptionQueueSize (int p0)
		{
			if (id_setMaxExceptionQueueSize_I == IntPtr.Zero)
				id_setMaxExceptionQueueSize_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxExceptionQueueSize", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxExceptionQueueSize_I, __args);
			} finally {
			}
		}

		static IntPtr id_start_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='start' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("start", "(Landroid/content/Context;ILjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Start (global::Android.Content.Context p0, int p1, string p2, string p3)
		{
			if (id_start_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
