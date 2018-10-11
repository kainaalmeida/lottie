using System.Windows.Input;
using Xamarin.Forms;

namespace EasyImovel.Views
{
    public partial class LoginPage : ContentPage
    {

        public ICommand PlayingCommand { get; private set; }
        public ICommand FinishedCommand { get; private set; }
        public ICommand ClickedCommand { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void KAEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void KAEntry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.OldTextValue) && e.NewTextValue?.Length == 1)
            {
                //loginAnimate.Play();
                loginAnimate.PlayProgressSegment(0.0f, 0.65f);
            }
            else if (string.IsNullOrEmpty(e.NewTextValue))
            {
                //loginAnimate.PlayFrameSegment()
                loginAnimate.PlayProgressSegment(0.65f, 1f);
            }
        }
    }
}
