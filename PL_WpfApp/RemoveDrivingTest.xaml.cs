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

namespace PL_WpfApp
{
    /// <summary>
    /// Interaction logic for RemoveDrivingTest.xaml
    /// </summary>
    public partial class RemoveDrivingTest : Window
    {
        private static BL.IBL bl = BL.FactorySingletonBL.getInstance();
        BE.DrivingTest drivingTest;

        public RemoveDrivingTest()
        {
            InitializeComponent();
            drivingTest = new BE.DrivingTest { Date = new DateTime(2019, 02, 10),StartingPoint=new Address(),carType=new CarType(),requirements=new Requirements()};
            this.DataContext = drivingTest;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.RemoveDrivingTest(drivingTest);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
            }
        }
    }
}
