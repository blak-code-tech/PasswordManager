using Firebase.Auth;
using PasswordManager.AppComposition.Services.Notification;

namespace PasswordManager.AppComposition.Helpers.Statics
{
    public class StaticMethods<T> where T : ContentPage
    {
        public static async Task HandleFirebaseAuthError(T page, AuthErrorReason reason, string exceptionMessage = "")
        {
            bool shouldGetUserOut = false;

            string message;
            switch (reason)
            {
                case AuthErrorReason.Undefined:
                    message = "Something went wrong. Check you internet connection.";
                    break;
                case AuthErrorReason.Unknown:
                    message = "Something went wrong.";
                    break;
                case AuthErrorReason.OperationNotAllowed:
                    message = "This sign method is not allowed.";
                    break;
                case AuthErrorReason.UserDisabled:
                    message = "Your account has been disabled.";
                    break;
                case AuthErrorReason.UserNotFound:
                    message = "Could not find an account with the given credentials.";
                    break;
                case AuthErrorReason.InvalidProviderID:
                    message = "Something went wrong.";
                    break;
                case AuthErrorReason.InvalidAccessToken:
                    message = "Something went wrong.";
                    break;
                case AuthErrorReason.LoginCredentialsTooOld:
                    message = "There has been some changes since your last log in, you will have to login again.";
                    shouldGetUserOut = true;
                    break;
                case AuthErrorReason.MissingRequestURI:
                    message = "Something went wrong.";
                    break;
                case AuthErrorReason.SystemError:
                    message = "Something went wrong.";
                    break;
                case AuthErrorReason.InvalidEmailAddress:
                    message = "The email you entered is invalid.";
                    break;
                case AuthErrorReason.MissingPassword:
                    message = "Kindly enter your password.";
                    break;
                case AuthErrorReason.WeakPassword:
                    message = "The password you have entered is weak, kindly enter a match stronger password.";
                    break;
                case AuthErrorReason.EmailExists:
                    message = "There is an account associated with the email provided.";
                    break;
                case AuthErrorReason.MissingEmail:
                    message = "Make sure you have entered a valid email address.";
                    break;
                case AuthErrorReason.UnknownEmailAddress:
                    message = "The email you entered does not match any account.";
                    break;
                case AuthErrorReason.WrongPassword:
                    message = "The password you have entered is incorrect.";
                    break;
                case AuthErrorReason.TooManyAttemptsTryLater:
                    message = "Too many password login have been attempted. Try again later.";
                    break;
                case AuthErrorReason.MissingRequestType:
                    message = "Something went wrong.";
                    break;
                case AuthErrorReason.ResetPasswordExceedLimit:
                    message = "Reset password limit exceeded.";
                    break;
                case AuthErrorReason.InvalidIDToken:
                    message = "Authenticated User ID token is invalid.";
                    break;
                case AuthErrorReason.MissingIdentifier:
                    message = "Something went wrong.";
                    break;
                case AuthErrorReason.InvalidIdentifier:
                    message = "Something went wrong.";
                    break;
                case AuthErrorReason.AlreadyLinked:
                    message = "Account to link has already been linked.";
                    break;
                case AuthErrorReason.InvalidApiKey:
                    message = "Something went wrong.";
                    break;
                case AuthErrorReason.AccountExistsWithDifferentCredential:
                    message = "The email user tried to login in with is already registered under a different provider.";
                    break;
                default:
                    message = "Something went wrong.";
                    break;
            }

            if (!string.IsNullOrWhiteSpace(exceptionMessage))
            {
                Console.WriteLine($"Message: {exceptionMessage}");
            }

            if (shouldGetUserOut)
            {
                await page.DisplayAlert("Attention", message, "OK");
                await PasswordManager.AppComposition.Services.InAppAuthenticationServices.SignOutUser();
                await Shell.Current.GoToAsync("///login");
            }
            else
            {
                await InAppNotification<T>.ShowSnackBarAsync(page, message);
            }
        }
    }
}
