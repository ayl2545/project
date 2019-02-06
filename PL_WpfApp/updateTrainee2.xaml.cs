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

namespace PL_WpfApp
{
    /// <summary>
    /// Interaction logic for updateTrainee2.xaml
    /// </summary>
    public partial class updateTrainee2 : Window
    {
        private static BL.IBL bl = BL.FactorySingletonBL.getInstance();
        public updateTrainee2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.UpdateTrainee((BE.Trainee)this.DataContext);
                Close();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);

            }
        }
    }
}
