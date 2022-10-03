using PasswordManager.AppComposition.Enums;

namespace PasswordManager.AppComposition.Model
{
    public class Password
    {
        /// <summary>
        /// This is the icon of the site or app the user wants to save
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// This is the name of the app the user wants to save
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// This is the email or username the user used of the app
        /// </summary>
        public string EmailOrUsername { get; set; }

        /// <summary>
        /// The string representation of the password strength
        /// </summary>
        public PasswordStrengthEnum PasswordStrength { get; set; }

        /// <summary>
        /// This is the numerical representation of the password strength
        /// </summary>
        public double PasswordStrengthValue { get; set; }

        /// <summary>
        /// This is the group the password belongs to.
        /// </summary>
        public PasswordGroup Group { get; set; }
    }
}
