using Prism;
using Prism.Ioc;
using EasyImovel.ViewModels;
using EasyImovel.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using EasyImovel.Service.Abstract;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EasyImovel
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {

            LiveReload.Init();

            InitializeComponent();

            var token = Xamarin.Essentials.Preferences.Get("token", "");

            if (string.IsNullOrEmpty(token))
                await NavigationService.NavigateAsync($"{nameof(LoginPage)}");
            else
                await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}");


        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.Register<IService, Service.Implements.Service>();
            containerRegistry.RegisterForNavigation<LoginPage>();
            containerRegistry.RegisterForNavigation<CadastroPage>();
        }
    }
}
