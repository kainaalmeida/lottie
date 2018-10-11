package md592f7fe7e89e1492ea8cfce56ed4288e9;


public class GestureFrameRenderer
	extends md58432a647068b097f9637064b8985a5e0.FrameRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Flex.Android.CustomRenderers.GestureFrameRenderer, Flex.Android", GestureFrameRenderer.class, __md_methods);
	}


	public GestureFrameRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == GestureFrameRenderer.class)
			mono.android.TypeManager.Activate ("Flex.Android.CustomRenderers.GestureFrameRenderer, Flex.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public GestureFrameRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == GestureFrameRenderer.class)
			mono.android.TypeManager.Activate ("Flex.Android.CustomRenderers.GestureFrameRenderer, Flex.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public GestureFrameRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == GestureFrameRenderer.class)
			mono.android.TypeManager.Activate ("Flex.Android.CustomRenderers.GestureFrameRenderer, Flex.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

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
