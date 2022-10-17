using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using PasswordManager.AppComposition.Statics;
using Font = Microsoft.Maui.Font;

namespace PasswordManager.AppComposition.Services.Notification
{
    /// <summary>
    /// This class will handle In app notifications, this includes toasts and snackbar notifications
    /// </summary>
    /// <typeparam name="T">The page on which the notification will appear.</typeparam>
    public static class InAppNotification<T> where T : ContentPage
    {
        /// <summary>
        /// This will show a snackbar notification in any location specified
        /// </summary>
        /// <param name="page">The page's instance</param>
        /// <param name="action">The action button text</param>
        /// <param name="message">The message to be displayed</param>
        /// <param name="actionButtonText">The name of an action button.</param>
        /// <returns></returns>
        public static async Task ShowSnackBarAsync(T page, string message, Action action = null,string actionButtonText = "OK")
        {
            try
            {
                SnackbarOptions options = new SnackbarOptions
                {
                    CornerRadius = new CornerRadius(15),
                    BackgroundColor = Color.FromArgb("#545974"), 
                    ActionButtonFont = Font.Default,
                    Font = Font.Default, 
                    TextColor = Colors.White
                };

                await page.DisplaySnackbar(message,action,actionButtonText,AppConstants.SnackBarDuration, visualOptions: options);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
