package crc643b5728eda735619c;


public class BlazorWebView_ValueCallback_1
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.webkit.ValueCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onReceiveValue:(Ljava/lang/Object;)V:GetOnReceiveValue_Ljava_lang_Object_Handler:Android.Webkit.IValueCallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("BlazorWebView.Android.BlazorWebView+ValueCallback`1, BlazorWebView.Android", BlazorWebView_ValueCallback_1.class, __md_methods);
	}


	public BlazorWebView_ValueCallback_1 ()
	{
		super ();
		if (getClass () == BlazorWebView_ValueCallback_1.class)
			mono.android.TypeManager.Activate ("BlazorWebView.Android.BlazorWebView+ValueCallback`1, BlazorWebView.Android", "", this, new java.lang.Object[] {  });
	}


	public void onReceiveValue (java.lang.Object p0)
	{
		n_onReceiveValue (p0);
	}

	private native void n_onReceiveValue (java.lang.Object p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
