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
    /// Interaction logic for UpdateTrainee.xaml
    /// </summary>
    public partial class UpdateTrainee : Window
    {
        private static BL.IBL bl = BL.FactorySingletonBL.getInstance();
        BE.Trainee trainee;
        public UpdateTrainee()
        {
            InitializeComponent();
            trainee = new BE.Trainee { CarTrained = new CarType(), Address = new Address(), Name = new Name(), DayOfBirth = new DateTime(2000, 01, 01), Gender = new Gender(), };
            this.DataContext = trainee;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.UpdateTrainee(trainee);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
            }
        }
    }
}
