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
using BE;
using BL;

namespace PL_WpfApp
{
    /// <summary>
    /// Interaction logic for AddDrivingTest.xaml
    /// </summary>
    public partial class AddDrivingTest : Window
    {
        private static BL.IBL bl = BL.FactorySingletonBL.getInstance();
        BE.DrivingTest drivingTest = new BE.DrivingTest();
        public AddDrivingTest()
        {
            
            InitializeComponent();
            drivingTest.Date = DateTime.Today;
            drivingTest.Date = drivingTest.Date.AddHours(9);
            DataContext = drivingTest;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //drivingTest=new BE.DrivingTest() {Trainee_ID=this.trainee_IDTextBox.Text,Date=(DateTime)this.dateDatePicker }
            //drivingTest = (BE.DrivingTest)DataContext;
            try
            {
                drivingTest.Date = drivingTest.Date.AddHours(9);
                bl.AddDrivingTest(drivingTest);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

    }
}
