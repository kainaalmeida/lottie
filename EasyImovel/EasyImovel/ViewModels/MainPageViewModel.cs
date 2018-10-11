using EasyImovel.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace EasyImovel.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public DelegateCommand CadastroCmd { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            CadastroCmd = new DelegateCommand(ExecuteCadastroCmd);
        }

        private async void ExecuteCadastroCmd()
        {
            await NavigationService.NavigateAsync($"{nameof(CadastroPage)}");
        }
    }
}
