using System.Globalization;

namespace PasswordManager.AppComposition.Converters
{
    public class PasswordStrengthColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return Color.FromRgb(0,0,0);

            double passwordStrength = (double)value;

            if (passwordStrength < 45)  return Color.FromArgb("#F8981D");

            else if(passwordStrength >= 90)  return Color.FromArgb("#1ED760");

            else if (passwordStrength > 45 && passwordStrength < 90) return Color.FromArgb("3E8EED");

            return Color.FromRgb(0, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
