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

namespace Demo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            aLabel.Content = "Ja";
            bLabel.Content = "Ja";
            cLabel.Content = "Ja";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            aLabel.Content = "Nee";
            bLabel.Content = "Nee";
            cLabel.Content = "Nee";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            aLabel.Content = "A";
            bLabel.Content = "B";
            cLabel.Content = "C";
        }
    }
}
