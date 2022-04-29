using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Media_Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ImageOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|Jpeg files (*.jpg)|*.jpg|Png files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            // openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            bool? res = openFileDialog.ShowDialog();
            if(res == true)
            {
                string imagepath = openFileDialog.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagepath);
                bitmap.EndInit();
                ImageBox.Source = bitmap;
            }
        }
        private void ImageSaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image";
            saveFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|Jpeg files (*.jpg)|*.jpg|Png files (*.png)|*.png|All files (*.*)|*.*";
            bool? res = saveFileDialog.ShowDialog();
            if(res == true)
            {
                string dispath = saveFileDialog.FileName;

                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)ImageBox.Source));

                using (FileStream stream = new FileStream(dispath, FileMode.Create))
                    encoder.Save(stream);
            }
        }
        private void VideoOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Vido";
            openFileDialog.Filter = "Mp4 files (*.mp4)|*.mp4|MKV files (*.mkv)|*.mkv|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            // openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            bool? res = openFileDialog.ShowDialog();
            if (res == true)
            {
                string videopath = openFileDialog.FileName;
                VideoBox.Source = new Uri(videopath);
                VideoBox.Play();
            }
        }
        private void StopVideo_Click(object sender, RoutedEventArgs e)
        {
            VideoBox.Stop();
        }
    }
}
