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

namespace CardioFitWPF
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

        private void btn_FreqBtmMaxMin_Click(object sender, RoutedEventArgs e)
        {
            FrequenzaMassimaMinima frequenza = new FrequenzaMassimaMinima();
            frequenza.Show();
        }

        private void btn_BaticardiaNormaleTachicardia_Click(object sender, RoutedEventArgs e)
        {
            BaticardiaNormaleTachicardia baticardiaTachicardia = new BaticardiaNormaleTachicardia();
            baticardiaTachicardia.Show();
        }
    }
}
