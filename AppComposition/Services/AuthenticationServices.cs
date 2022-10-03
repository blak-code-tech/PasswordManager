// main namespaces
using Firebase.Auth;
using Firebase.Auth.Providers;
using Newtonsoft.Json;
using PasswordManager.AppComposition.Statics;

namespace PasswordManager.AppComposition.Services
{
    public static class AuthenticationServices
    {

        /// <summary>
        /// We try to connect to the firebase servers
        /// </summary>
        /// <returns>FirebaseAuthClient</returns>
        public static FirebaseAuthClient GetFirebaseClient()
        {
            // Configure...
            var config = new FirebaseAuthConfig
            {
                ApiKey = AppConstants.firebaseAPIKey,
                AuthDomain = AppConstants.firebaseDomain,
                Providers = new FirebaseAuthProvider[]
                {
                    // Add and configure individual providers
                    new GoogleProvider().AddScopes("email"),
                    new EmailProvider()
                    // ...
                }
            };

            // ...and create your FirebaseAuthClient
            var client = new FirebaseAuthClient(config);

            return client;
        }

        /// <summary>
        /// Sign Up a new user using email and password
        /// We also allow the use to set a display name.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="displayName"></param>
        /// <returns>UserCredential</returns>
        public static async Task<UserCredential> SignUpUserWithEmailAndPassword(string email, string password,string displayName = "")
        {
            var client = GetFirebaseClient();
            var userCredential = await client.CreateUserWithEmailAndPasswordAsync(email, password, displayName);

            return userCredential;
        }

        /// <summary>
        /// Sign in a user using their email and password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>UserCredential</returns>
        public static async Task<UserCredential> SignInUserWithEmailAndPassword(string email, string password)
        {
            var client = GetFirebaseClient();

            var userCredential = await client.SignInWithEmailAndPasswordAsync(email, password);

            return userCredential;
        }

        /// <summary>
        /// Sign In a user using email and password on a web page
        /// </summary>
        /// <returns>UserCredential</returns>
        public static async Task<UserCredential> SignInWithWebRedirect()
        {
            // sign in via web browser redirect - navigate to given uri, monitor a redirect to 
            // your authdomain.firebaseapp.com/__/auth/handler
            // and return the whole redirect uri back to the client;
            // this method is actually used by FirebaseUI
            var client = GetFirebaseClient();

            var userCredential = await client.SignInWithRedirectAsync(FirebaseProviderType.EmailAndPassword, async uri =>
            {
                return await OpenBrowserAndWaitForRedirectToAuthDomain(uri);
            });

            return userCredential;
        }

        /// <summary>
        /// Take us to the web page to authenticate a user
        /// with their email and password.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns>string</returns>
        /// <exception cref="NotImplementedException"></exception>
        private static Task<string> OpenBrowserAndWaitForRedirectToAuthDomain(string uri)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Used to fetch the Refreshed token
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string GetRefreshToken()
        {
            try
            {
                var userCredentials = GetUserCredentialsFromPreferences();

                return userCredentials.User.Credential.RefreshToken;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Fetches the UserCredential object from preferences
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static UserCredential GetUserCredentialsFromPreferences()
        {
            if (Preferences.ContainsKey("UserCredentials"))
            {
                var userCredential = JsonConvert.DeserializeObject<UserCredential>(Preferences.Get("UserCredentials", null));

                return userCredential;
            }
            else
            {
                throw new Exception("Could not find the UserCredential slot.");
            }
        }

        /// <summary>
        /// Save User credentials
        /// </summary>
        /// <param name="userCredential"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static async Task<bool> SaveUserCredentialInformation(UserCredential userCredential)
        {
            if (userCredential == null)
            {
                throw new NullReferenceException("The UserCredential passed is null");
            }

            try
            {
                await AddUserDetailsToPreferencesAndSecureStorage(userCredential);

                var stringifiedUserCredential = JsonConvert.SerializeObject(userCredential, Formatting.Indented);

                Preferences.Set("UserCredentials", stringifiedUserCredential);

                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Add the User credential properties to preferences and secure storage.
        /// </summary>
        /// <param name="userCredential"></param>
        /// <returns>Nothing</returns>
        private static async Task AddUserDetailsToPreferencesAndSecureStorage(UserCredential userCredential)
        {
            //Saving user personal info
            Preferences.Set("email", userCredential.User.Info.Email);
            Preferences.Set("first_name", userCredential.User.Info.FirstName);
            Preferences.Set("last_name", userCredential.User.Info.LastName);
            Preferences.Set("display_name", userCredential.User.Info.DisplayName);
            Preferences.Set("photo_url", userCredential.User.Info.PhotoUrl);
            Preferences.Set("uid", userCredential.User.Info.Uid);
            Preferences.Set("federated_id", userCredential.User.Info.FederatedId);
            Preferences.Set("is_email_verified", userCredential.User.Info.IsEmailVerified);

            //Saving Credential info
            Preferences.Set("provider_type", userCredential.User.Credential.ProviderType.ToString());
            await SecureStorage.SetAsync("token", userCredential.User.Credential.IdToken);
            await SecureStorage.SetAsync("created_date", userCredential.User.Credential.Created.ToLongDateString());
        }

        /// <summary>
        /// Change a user's password
        /// </summary>
        /// <param name="password"></param>
        /// <returns>Whether or not the password was changed successfully.</returns>
        public static async Task<bool> ChangeUserPassword(string password)
        {
            try
            {
                var userCredential = GetUserCredentialsFromPreferences();
                await userCredential.User.ChangePasswordAsync(password);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Sign a user out of the app and the firebase client
        /// </summary>
        /// <returns>Whether or not the process was successful.</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<bool> SignOutUser()
        {
            try
            {
                var client = GetFirebaseClient();
                Preferences.Clear();
                SecureStorage.RemoveAll();
                await client.SignOutAsync();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
