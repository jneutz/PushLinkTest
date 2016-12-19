using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pushlink.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']"
	[global::Android.Runtime.Register ("com/pushlink/android/FriendlyPopUpStrategy", DoNotGenerateAcw=true)]
	public sealed partial class FriendlyPopUpStrategy : global::Com.Pushlink.Android.Strategy {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pushlink/android/FriendlyPopUpStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FriendlyPopUpStrategy); }
		}

		internal FriendlyPopUpStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getHash;
		public unsafe string Hash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='getHash' and count(parameter)=0]"
			[Register ("getHash", "()Ljava/lang/String;", "GetGetHashHandler")]
			get {
				if (id_getHash == IntPtr.Zero)
					id_getHash = JNIEnv.GetMethodID (class_ref, "getHash", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHash), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getNotNowButton;
		static IntPtr id_setNotNowButton_Ljava_lang_String_;
		public unsafe string NotNowButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='getNotNowButton' and count(parameter)=0]"
			[Register ("getNotNowButton", "()Ljava/lang/String;", "GetGetNotNowButtonHandler")]
			get {
				if (id_getNotNowButton == IntPtr.Zero)
					id_getNotNowButton = JNIEnv.GetMethodID (class_ref, "getNotNowButton", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotNowButton), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='setNotNowButton' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotNowButton", "(Ljava/lang/String;)V", "GetSetNotNowButton_Ljava_lang_String_Handler")]
			set {
				if (id_setNotNowButton_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotNowButton_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotNowButton", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotNowButton_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getPopUpMessage;
		static IntPtr id_setPopUpMessage_Ljava_lang_String_;
		public unsafe string PopUpMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='getPopUpMessage' and count(parameter)=0]"
			[Register ("getPopUpMessage", "()Ljava/lang/String;", "GetGetPopUpMessageHandler")]
			get {
				if (id_getPopUpMessage == IntPtr.Zero)
					id_getPopUpMessage = JNIEnv.GetMethodID (class_ref, "getPopUpMessage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPopUpMessage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='setPopUpMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPopUpMessage", "(Ljava/lang/String;)V", "GetSetPopUpMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setPopUpMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setPopUpMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPopUpMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPopUpMessage_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getReminderTimeInSeconds;
		static IntPtr id_setReminderTimeInSeconds_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer ReminderTimeInSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='getReminderTimeInSeconds' and count(parameter)=0]"
			[Register ("getReminderTimeInSeconds", "()Ljava/lang/Integer;", "GetGetReminderTimeInSecondsHandler")]
			get {
				if (id_getReminderTimeInSeconds == IntPtr.Zero)
					id_getReminderTimeInSeconds = JNIEnv.GetMethodID (class_ref, "getReminderTimeInSeconds", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReminderTimeInSeconds), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='setReminderTimeInSeconds' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setReminderTimeInSeconds", "(Ljava/lang/Integer;)V", "GetSetReminderTimeInSeconds_Ljava_lang_Integer_Handler")]
			set {
				if (id_setReminderTimeInSeconds_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setReminderTimeInSeconds_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setReminderTimeInSeconds", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReminderTimeInSeconds_Ljava_lang_Integer_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getUpdateButton;
		static IntPtr id_setUpdateButton_Ljava_lang_String_;
		public unsafe string UpdateButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='getUpdateButton' and count(parameter)=0]"
			[Register ("getUpdateButton", "()Ljava/lang/String;", "GetGetUpdateButtonHandler")]
			get {
				if (id_getUpdateButton == IntPtr.Zero)
					id_getUpdateButton = JNIEnv.GetMethodID (class_ref, "getUpdateButton", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateButton), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='setUpdateButton' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUpdateButton", "(Ljava/lang/String;)V", "GetSetUpdateButton_Ljava_lang_String_Handler")]
			set {
				if (id_setUpdateButton_Ljava_lang_String_ == IntPtr.Zero)
					id_setUpdateButton_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUpdateButton", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateButton_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
