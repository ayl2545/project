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
using System.Windows.Shapes;
using BE;
using BL;

namespace PL_WpfApp
{
    /// <summary>
    /// Interaction logic for UpdateTrainee.xaml
    /// </summary>
    public partial class UpdateTrainee : Window
    {
        private static BL.IBL bl = BL.FactorySingletonBL.getInstance();
        BE.Trainee trainee;
        public UpdateTrainee()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               trainee= bl.findTrainee(iDTextBox.Text);
                updateTrainee2 UpdateTrainee2 = new updateTrainee2();
                UpdateTrainee2.DataContext = trainee;
                UpdateTrainee2.Show();
                Close();
               
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
             
            }

            
        }

    

       
    }
}
