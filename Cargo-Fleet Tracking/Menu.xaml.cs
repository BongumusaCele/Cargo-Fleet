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

namespace Cargo_Fleet_Tracking
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddClient addClient = new AddClient();

            addClient.Show();

            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SetAppointment goSet = new SetAppointment();

            goSet.Show();

            Hide();
        }

        private void btn_AddVehicle_Click(object sender, RoutedEventArgs e)
        {
            AddVehicleInfo addVehicle = new AddVehicleInfo();

            addVehicle.Show();

            Hide();
        }

        private void btn_AddTrip_Click(object sender, RoutedEventArgs e)
        {
            AddTripDetails addTrip = new AddTripDetails();

            addTrip.Show();

            Hide();
        }

        private void btn_ViewReports_Click(object sender, RoutedEventArgs e)
        {
            ViewReports viewReport = new ViewReports();

            viewReport.Show();

            Hide();
        }
    }
}
