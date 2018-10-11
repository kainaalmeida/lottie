using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EasyImovel.Droid.Renderer;
using EasyImovel.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(KAEntry), typeof(KAEntryRenderer))]
namespace EasyImovel.Droid.Renderer
{
    public class KAEntryRenderer : EntryRenderer
    {
        public KAEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var element = Element as KAEntry;

            if (Control != null)
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                    Control.BackgroundTintList = ColorStateList.ValueOf(element.ColorLine.ToAndroid());
                else
                    Control.Background.SetColorFilter(element.ColorLine.ToAndroid(), PorterDuff.Mode.SrcAtop);
            }

        }
    }
}