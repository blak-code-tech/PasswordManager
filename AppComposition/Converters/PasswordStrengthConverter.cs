using System.Globalization;

namespace PasswordManager.AppComposition.Converters
{
    public class PasswordStrengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "";

            int passwordStrength = (int)value;

            if (passwordStrength == 0)  return "Weak";

            else if(passwordStrength == 1)  return "Safe";

            else if (passwordStrength == 2) return "Strong";

            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
