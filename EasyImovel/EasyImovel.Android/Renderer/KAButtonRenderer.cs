using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EasyImovel.Droid.Renderer;
using EasyImovel.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(KAButton),typeof(KAButtonRenderer))]
namespace EasyImovel.Droid.Renderer
{
    public class KAButtonRenderer : Xamarin.Forms.Platform.Android.ButtonRenderer
    {
        public KAButtonRenderer(Context context) : base(context)
        {
        }

        //protected override void OnDraw(Canvas canvas)
        //{
        //    base.OnDraw(canvas);
        //}

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            var element = Element as KAButton;

            if (Control != null)
            {
                var gb = new GradientDrawable();
                gb.SetColor(element.BGColor.ToAndroid());
                gb.SetCornerRadius((float)element.Rounded);

                Control.Background = gb;
            }
        }

    }
}