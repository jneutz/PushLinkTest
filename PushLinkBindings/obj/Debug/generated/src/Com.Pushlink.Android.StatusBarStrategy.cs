using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pushlink.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']"
	[global::Android.Runtime.Register ("com/pushlink/android/StatusBarStrategy", DoNotGenerateAcw=true)]
	public sealed partial class StatusBarStrategy : global::Com.Pushlink.Android.Strategy {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pushlink/android/StatusBarStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatusBarStrategy); }
		}

		internal StatusBarStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getHash;
		static IntPtr id_setHash_Ljava_lang_String_;
		public unsafe string Hash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='getHash' and count(parameter)=0]"
			[Register ("getHash", "()Ljava/lang/String;", "GetGetHashHandler")]
			get {
				if (id_getHash == IntPtr.Zero)
					id_getHash = JNIEnv.GetMethodID (class_ref, "getHash", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHash), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='setHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHash", "(Ljava/lang/String;)V", "GetSetHash_Ljava_lang_String_Handler")]
			set {
				if (id_setHash_Ljava_lang_String_ == IntPtr.Zero)
					id_setHash_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHash", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHash_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getStatusBarDescription;
		static IntPtr id_setStatusBarDescription_Ljava_lang_String_;
		public unsafe string StatusBarDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='getStatusBarDescription' and count(parameter)=0]"
			[Register ("getStatusBarDescription", "()Ljava/lang/String;", "GetGetStatusBarDescriptionHandler")]
			get {
				if (id_getStatusBarDescription == IntPtr.Zero)
					id_getStatusBarDescription = JNIEnv.GetMethodID (class_ref, "getStatusBarDescription", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatusBarDescription), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='setStatusBarDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatusBarDescription", "(Ljava/lang/String;)V", "GetSetStatusBarDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setStatusBarDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatusBarDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatusBarDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatusBarDescription_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getStatusBarTitle;
		static IntPtr id_setStatusBarTitle_Ljava_lang_String_;
		public unsafe string StatusBarTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='getStatusBarTitle' and count(parameter)=0]"
			[Register ("getStatusBarTitle", "()Ljava/lang/String;", "GetGetStatusBarTitleHandler")]
			get {
				if (id_getStatusBarTitle == IntPtr.Zero)
					id_getStatusBarTitle = JNIEnv.GetMethodID (class_ref, "getStatusBarTitle", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatusBarTitle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='setStatusBarTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatusBarTitle", "(Ljava/lang/String;)V", "GetSetStatusBarTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setStatusBarTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatusBarTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatusBarTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatusBarTitle_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
