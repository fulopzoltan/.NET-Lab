using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace FileExplorerApp.helper
{
    [ValueConversion(typeof(string), typeof(BitmapImage))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter headerToImageConverter = new();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string path = (string) value;
            if (path == null)
                return null;
            string name = MainWindow.getFileFolderName(path);
            string image = "Images/file.png";
            if (string.IsNullOrEmpty(name))
                image = "Images/drive.png";
            else if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
                image = "Images/folder.png";
            return new BitmapImage(new Uri($"pack://application:,,/{image}"));
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}