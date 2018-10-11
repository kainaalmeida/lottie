using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace EasyImovel.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                var location = await Geolocation.GetLocationAsync();

                if (location != null)
                {
                    var position = new Position(location.Latitude, location.Longitude);
                    maps.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMeters(1000)));

                    var circle = new Circle();
                    circle.StrokeColor = Color.FromHex("#62397F");
                    circle.FillColor = Color.FromRgba(207, 84, 128, .5);
                    circle.StrokeWidth = 10f;
                    circle.Center = position;
                    circle.Radius = Distance.FromMeters(10);
                    maps.Circles.Add(circle);

                }

            }
            catch (Exception)
            {
            }
        }
    }
}