using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.HelperClasses.Converters;
public class InquiryStatusFormatter : IValueConverter {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
        value = value.ToString();
        switch (value) {
            case "InProgress":
                return "In progress...";
            case "OnHold":
                return "On hold...";
            default:
                return value;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
        throw new NotImplementedException();
    }
}
