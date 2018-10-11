using Xamarin.Forms;

namespace EasyImovel.Renderer
{
    public class KAButton : Button
    {
        public static readonly BindableProperty RoundedProperty =
                                                    BindableProperty.Create(
                                                    "Rounded",
                                                    typeof(int),
                                                    typeof(KAButton),
                                                    defaultValue: 0);

        public int Rounded
        {
            get { return (int)GetValue(RoundedProperty); }
            set { SetValue(RoundedProperty, value); }
        }

        public new static readonly BindableProperty BorderColorProperty =
                                                    BindableProperty.Create(
                                                    "BorderColor",
                                                    typeof(Color),
                                                    typeof(KAButton),
                                                    default(Color));

        public new Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty BGColorProperty =
                                                    BindableProperty.Create(
                                                    "BGColor",
                                                    typeof(Color),
                                                    typeof(KAButton),
                                                    default(Color));

        public Color BGColor
        {
            get { return (Color)GetValue(BGColorProperty); }
            set { SetValue(BGColorProperty, value); }
        }

    }
}
