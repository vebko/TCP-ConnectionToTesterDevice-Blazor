package crc643b5728eda735619c;


public class BlazorJavascriptInterface
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_PostMessage:(Ljava/lang/String;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("BlazorWebView.Android.BlazorJavascriptInterface, BlazorWebView.Android", BlazorJavascriptInterface.class, __md_methods);
	}


	public BlazorJavascriptInterface ()
	{
		super ();
		if (getClass () == BlazorJavascriptInterface.class)
			mono.android.TypeManager.Activate ("BlazorWebView.Android.BlazorJavascriptInterface, BlazorWebView.Android", "", this, new java.lang.Object[] {  });
	}

	public BlazorJavascriptInterface (crc643b5728eda735619c.BlazorWebView p0)
	{
		super ();
		if (getClass () == BlazorJavascriptInterface.class)
			mono.android.TypeManager.Activate ("BlazorWebView.Android.BlazorJavascriptInterface, BlazorWebView.Android", "BlazorWebView.Android.BlazorWebView, BlazorWebView.Android", this, new java.lang.Object[] { p0 });
	}

	@android.webkit.JavascriptInterface

	public void PostMessage (java.lang.String p0)
	{
		n_PostMessage (p0);
	}

	private native void n_PostMessage (java.lang.String p0);

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
