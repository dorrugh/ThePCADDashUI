using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Diagnostics;
using System.Net;
using System.ComponentModel;
using System.IO;

namespace ThePCADDashUI
{
    /// <summary>
    /// Interaction logic for GameLauncher.xaml
    /// </summary>
    public partial class GameLauncher : Window
    {
        public GameLauncher()
        {
            InitializeComponent();
        }
        //executes the ThePCADDash.exe directly from file path
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Users\wthom\source\repos\ThePCADDash-Final\bin\Debug\ThePCADDash-Final.exe");
            this.Close();
        
        }
        //uses the webClient class to download file asynchrousnly directly from the passed link into the specificed download location
        //used the Async method to keep the UI active while file is downloading
        private void Download_Click(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1FpLQOwUehXp2_NkyNM0JgWcHHFEiqs-s"), @"C:\Users\wthom\Downloads\Version.txt");
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);           
        }
        //shows a messgae box when the download file is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed!");
        }
        //event handler for my custom close button in corner of UI Window
        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //event handler for my custom close button in corner of UI Window
        private void MinimizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
