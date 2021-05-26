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

namespace BindingExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestBinding tb;
        public MainWindow()
        {
            InitializeComponent();
            tb = new TestBinding();
            TB1.DataContext = tb;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb.TestProp = TB2.Text;
        }

    }
}
