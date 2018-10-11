using Xamarin.Forms;

namespace EasyImovel.Renderer
{
    public class KAEntry : Entry
    {
        public static readonly BindableProperty ColorLineProperty =
                                                    BindableProperty.Create(
                                                    "ColorLine",
                                                    typeof(Color),
                                                    typeof(KAEntry),
                                                    defaultValue: Color.White);

        public Color ColorLine
        {
            get { return (Color)GetValue(ColorLineProperty); }
            set { SetValue(ColorLineProperty, value); }
        }
    }
}
