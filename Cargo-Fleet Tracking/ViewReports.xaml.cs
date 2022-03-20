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
    /// Interaction logic for ViewReports.xaml
    /// </summary>
    public partial class ViewReports : Window
    {
        public ViewReports()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Menu goBack = new Menu();

            goBack.Show();

            Hide();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_VehicleStatusReport_Click(object sender, RoutedEventArgs e)
        {
            VehicleStatusReport statusReport = new VehicleStatusReport();

            statusReport.Show();

            Hide();
        }

        private void btn_AppointmentReport_Click(object sender, RoutedEventArgs e)
        {
            AppointmentReport appointment = new AppointmentReport();

            appointment.Show();

            Hide();
        }

        private void btn_PlannedTripReport_Click(object sender, RoutedEventArgs e)
        {
            CompletedTripReport completed = new CompletedTripReport();

            completed.Show();

            Hide();
        }
    }
}
