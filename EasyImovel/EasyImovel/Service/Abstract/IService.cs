using Firebase.Auth;
using System;

namespace EasyImovel.Service.Abstract
{
    public interface IService : IDisposable
    {
        FirebaseAuthProvider Configure();
    }
}
