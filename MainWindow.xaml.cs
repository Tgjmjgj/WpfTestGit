﻿using System;
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
            MessageBox.Show("Test method for user 2");
            int a = 7;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(text1.Text + "!!!!!");

            double a = 11;
            double b = 3;
            double c = Math.Pow(a, b);

            double a = 15;
            int c = a % b;

        }
    }
}
