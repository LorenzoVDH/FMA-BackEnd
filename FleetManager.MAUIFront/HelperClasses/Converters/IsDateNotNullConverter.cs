using System.Globalization;

namespace FleetManager.MAUIFront.HelperClasses.Converters;
public class IsDateNotNullConverter : IValueConverter {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
        return value != null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
        throw new NotImplementedException();
    }
}
