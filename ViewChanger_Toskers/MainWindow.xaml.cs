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
using ViewChanger_Toskers.ViewModels;

namespace ViewChanger_Toskers
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

        private void RedButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new RedViewModel();
        }
        private void BlueButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new BlueViewModel();
        }

        private void OrangeButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new OrangeViewModel();
        }
    }
}
