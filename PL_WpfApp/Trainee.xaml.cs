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

namespace PL_WpfApp
{
    /// <summary>
    /// Interaction logic for Trainee.xaml
    /// </summary>
    public partial class Trainee : UserControl
    {
        public Trainee()
        {
            InitializeComponent();
        }

        private void Add_trainee_Click(object sender, RoutedEventArgs e)
        {
            AddTrainee addTrainee = new AddTrainee();
            addTrainee.Show();
        }

        private void Remove_trainee_Click(object sender, RoutedEventArgs e)
        {
            RemoveTrainee removeTrainee = new RemoveTrainee();
            removeTrainee.Show();
        }

        private void Update_trainee_Click(object sender, RoutedEventArgs e)
        {
            UpdateTrainee updateTrainee = new UpdateTrainee();
            updateTrainee.Show();
        }
    }
}
