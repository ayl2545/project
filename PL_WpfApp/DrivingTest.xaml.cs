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
    /// Interaction logic for DrivingTest.xaml
    /// </summary>
    public partial class DrivingTest : UserControl
    {
       
        public DrivingTest()
        {
            InitializeComponent();
            
        }

        private void Update_driving_test_Click(object sender, RoutedEventArgs e)
        {
            UpdateDrivingTest updateDrivingTest = new UpdateDrivingTest();
            updateDrivingTest.Show();
        }

        private void Add_driving_test_Click(object sender, RoutedEventArgs e)
        {
            AddDrivingTest addDrivingtest = new AddDrivingTest();
            addDrivingtest.Show();

        }

        private void Remove_driving_test_Click(object sender, RoutedEventArgs e)
        {
            RemoveDrivingTest removeDrivingTest = new RemoveDrivingTest();
            removeDrivingTest.Show();
        }
    }
}
