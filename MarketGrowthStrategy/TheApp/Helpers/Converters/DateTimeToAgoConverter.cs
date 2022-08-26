using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketGrowthStrategy.TheApp.Helpers.Converters
{
    public class DateTimeToAgoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not DateTime datetime)
            {
                return "";
            }

            var timePassed = DateTime.Now - datetime;

            if (timePassed < TimeSpan.FromMinutes(1))
            {
                return $"{timePassed.Seconds} seconds ago";
            }

            if (timePassed < TimeSpan.FromHours(1))
            {
                return $"{timePassed.Minutes} minutes ago";
            }

            if (timePassed < TimeSpan.FromDays(1))
            {
                return $"{timePassed.Hours} hours ago";
            }
               
            return $"{timePassed.Days} days ago";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
