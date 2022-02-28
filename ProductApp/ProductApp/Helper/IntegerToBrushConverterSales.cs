using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ProductApp.Helper;

public class IntegerToBrushConverterSales : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (int.Parse(value.ToString()) < 100) ? Brushes.Gray : Brushes.LawnGreen;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}