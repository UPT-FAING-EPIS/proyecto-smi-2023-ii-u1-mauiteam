using Firebase.Auth;
using Firebase.Auth.Providers;

namespace MangaVerse
{
    public class ConexionFirebase
    {
        public static FirebaseAuthClient ConectarFirebase()
        {
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyAdlhiayzbzLJcl8YWHDTUkiFYIdPgqc64",
                AuthDomain = "mangaverse-c5e33.web.app",
                Providers = new FirebaseAuthProvider[]
                {
                    // Add and configure individual providers
                    new GoogleProvider().AddScopes("email"),
                    new EmailProvider()
                    // ...
                },
            };

            var client = new FirebaseAuthClient(config);
            return client;
        }

        public async Task<UserCredential> CargarUsuario(string Email, string Password)
        {
            var cliente = ConectarFirebase();
            var userCredential = await cliente.SignInWithEmailAndPasswordAsync(Email, Password);
            
            return userCredential;
        }

        public async Task<UserCredential> CrearUsuario(string Email, string Password, string Username)
        {
            var cliente = ConectarFirebase();
            var userCredential = await cliente.CreateUserWithEmailAndPasswordAsync(Email, Password, Username);
            return userCredential;
        }
    }
}
