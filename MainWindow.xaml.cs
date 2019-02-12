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

namespace WpfTestGit
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void MethodForTest()
        {
            MessageBox.Show("Test method");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(text1.Text + "!!!!!");
<<<<<<< HEAD
            double a = 15;
            double b = 5;
            double c = Math.Pow(a, b);
=======
	    int a = 2;
 	    int b = 4;
            int c = a % b;
>>>>>>> 3bb2474de4c8ee849d72b3ec1b8e4a5e285053ae
        }
    }
}
