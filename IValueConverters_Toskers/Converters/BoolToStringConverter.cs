using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace IValueConverters_Toskers.Converters
{
    public class BoolToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var answerBool = (bool)value;
            if (answerBool)
                return "Yes";
            else
                return "No";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var answerString = (string)value;
            if (answerString.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                return true;
            else
                return false;
        }
    }
}
