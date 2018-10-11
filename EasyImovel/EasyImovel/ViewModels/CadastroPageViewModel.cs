using Plugin.Media;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyImovel.ViewModels
{
    public class CadastroPageViewModel : BindableBase
    {

        public DelegateCommand TakeCmd { get; set; }
        public DelegateCommand PickCmd { get; set; }

        private string img01;
        public string Img01
        {
            get { return img01; }
            set { SetProperty(ref img01, value); }
        }


        public CadastroPageViewModel()
        {
            TakeCmd = new DelegateCommand(ExecuteTakeCmd);
            PickCmd = new DelegateCommand(ExecutePickCmd);
        }

        private async void ExecutePickCmd()
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await App.Current.MainPage.DisplayAlert("Aviso!", "Dispositivo não possui câmera.", "OK");
                return;
            }

            await CrossMedia.Current.Initialize();

            var pick = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,

            });

            if (pick == null)
                return;

            Img01 = pick.Path;
        }

        private async void ExecuteTakeCmd()
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await App.Current.MainPage.DisplayAlert("Aviso!", "Dispositivo não possui câmera.", "OK");
                return;
            }

            await CrossMedia.Current.Initialize();

            var take = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (take == null)
                return;


            Img01 = take.Path;
        }
    }
}
