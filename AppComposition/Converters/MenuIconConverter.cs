using PasswordManager.Resources.Fonts;
using System.Globalization;

namespace PasswordManager.AppComposition.Converters
{
    public class MenuIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case true:
                    return FontIcons.AccountOutline;
                case false:
                    return FontIcons.ArrowLeft;
                default:
                    return FontIcons.Menu;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
