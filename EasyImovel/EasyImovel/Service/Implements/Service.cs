using EasyImovel.Service.Abstract;
using EasyImovel.Service.Implements;
using Firebase.Auth;

[assembly: Xamarin.Forms.Dependency(typeof(Service))]
namespace EasyImovel.Service.Implements
{
    public class Service : IService
    {
        public FirebaseAuthProvider Configure() =>  new FirebaseAuthProvider(new FirebaseConfig("YOUR_KEY"));

        public void Dispose() => Configure().Dispose();
    }
}
