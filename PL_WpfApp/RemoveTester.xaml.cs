﻿using BE;
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
using System.Windows.Shapes;
using BL;

namespace PL_WpfApp
{
    /// <summary>
    /// Interaction logic for RemoveTester.xaml
    /// </summary>
    public partial class RemoveTester : Window
    {
        private static BL.IBL bl = BL.FactorySingletonBL.getInstance();
        BE.Tester tester;
        public RemoveTester()
        {
            InitializeComponent();
            tester = new BE.Tester { DayOfBirth = new DateTime(2000, 1, 1), Address = new Address(), Name = new Name(), Expertise = new CarType(),Luz=new Schedule() };
            this.DataContext = tester;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.RemoveTester(tester);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
            }
        }
    }
}
