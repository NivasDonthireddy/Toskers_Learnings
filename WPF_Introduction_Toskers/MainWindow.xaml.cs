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
using WPF_Introduction_Toskers.Models;

namespace WPF_Introduction_Toskers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestModel button1DataContext = new TestModel() { Name = "I am Coming from Model - Button 1" };
            TestModel button2DataContext = new TestModel() { Name = "I am Coming from Model - Button 2" };

            btn1.DataContext = button1DataContext;
            btn2.DataContext = button2DataContext;
        }
    }
}
