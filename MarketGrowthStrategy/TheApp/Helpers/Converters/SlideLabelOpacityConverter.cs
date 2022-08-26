using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketGrowthStrategy.TheApp.Helpers.Converters
{
    internal class SlideLabelOpacityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null
                || values.Length != 2
                || values[0] is not double width
                || values[1] is not double translation
                || width <= 0)
            {
                return 1;
            }

            return (width - translation) / width;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
