using PasswordManager.Resources.Fonts;
using System;
using System.Globalization;

namespace PasswordManager.AppComposition.Converters
{
    public class PasswordVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case true:
                    return FontIcons.Eye;
                case false:
                    return FontIcons.EyeOff;
                default:
                    return FontIcons.Eye;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
