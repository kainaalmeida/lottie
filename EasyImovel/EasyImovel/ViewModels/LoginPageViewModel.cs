using EasyImovel.Service.Abstract;
using EasyImovel.Views;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using Xamarin.Forms;

namespace EasyImovel.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {

        private string email;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { SetProperty(ref senha, value); }
        }


        public DelegateCommand LoginCmd { get; set; }

        IService _service;
        IPageDialogService _pageDialogService;
        public LoginPageViewModel
            (
                INavigationService navigationService,
                IService service,
                IPageDialogService pageDialogService
            ) : base(navigationService)
        {
            _pageDialogService = pageDialogService;
            _service = service;
            LoginCmd = new DelegateCommand(ExecuteLoginCmd);
            this.IsBusy = false;
        }

        private async void ExecuteLoginCmd()
        {
            this.IsBusy = true;
            if (String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(Senha))
            {
                await _pageDialogService.DisplayAlertAsync("Aviso!", "Email e Password são obrigatórios", "OK");
                this.IsBusy = false;
            }
            else
            {
                var aufh = await _service.Configure().SignInWithEmailAndPasswordAsync(Email, Senha);

                if (aufh.User != null)
                {
                    Xamarin.Essentials.Preferences.Set("token",aufh.FirebaseToken);
                    this.IsBusy = false;
                    await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}");
                }

                if(aufh.User == null)
                {
                    await _pageDialogService.DisplayAlertAsync("Aviso!", "Email e/ou Password incorretos", "OK");
                    this.IsBusy = false;
                }

            }

        }
    }
}
