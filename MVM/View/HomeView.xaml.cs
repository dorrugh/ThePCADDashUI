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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ThePCADDashUI.MVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void LinkedIn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/walterthomas-mssa");
        }

        private void GitHub_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/features/codespaces");
        }

        private void StackOverflow_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://stackoverflow.com/");
        }

        private void Microsoft_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/");
        }

        private void CSharpCorner_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.c-sharpcorner.com/");
        }

        private void VisualStudio_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://visualstudio.microsoft.com/");
        }
    }
}
