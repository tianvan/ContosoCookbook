using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContosoCookbook.Converters
{
    public class ListConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Join("\r\n", (IEnumerable<string>)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
