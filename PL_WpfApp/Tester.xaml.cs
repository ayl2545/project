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

namespace PL_WpfApp
{
    /// <summary>
    /// Interaction logic for Tester.xaml
    /// </summary>
    public partial class Tester : UserControl
    {
        public Tester()
        {
            InitializeComponent();
        }

        private void Add_tester_Click(object sender, RoutedEventArgs e)
        {
            AddTester addTester = new AddTester();
            addTester.Show();
        }

        private void Remove_tester_Click(object sender, RoutedEventArgs e)
        {
            RemoveTester removeTester = new RemoveTester();
            removeTester.Show();
        }

        private void Update_tester_Click(object sender, RoutedEventArgs e)
        {
            UpdateTester updateTester = new UpdateTester();
            updateTester.Show();
        }
    }
}
