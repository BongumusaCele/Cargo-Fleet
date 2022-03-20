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
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace Cargo_Fleet_Tracking
{
    /// <summary>
    /// Interaction logic for AddTripDetails.xaml
    /// </summary>
    public partial class AddTripDetails : Window
    {
        //Declaring connection string
        public static string connectionStr = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\School\Diploma in Information Technology in Software Development\Second Year\Semester 2\Work Integrated Learning 2\POE\5 Implementation\Cargo-Fleet Tracking\Cargo-Fleet Tracking\Cargo-Fleet_Database.mdf;Integrated Security = True";
        //Establishing a sql connection 
        SqlConnection connect = new SqlConnection(connectionStr);

        public AddTripDetails()
        {
            InitializeComponent();
            try
            {
                //opening connection
                connect.Open();
            }
            catch (Exception error)
            {
                //display error if connection has failed
                MessageBox.Show(error.ToString());
            }

        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Menu goBack = new Menu();

            goBack.Show();

            Hide();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Declaring a string to store sql query code
                string SQLquery2 = "INSERT INTO TRIPS (VEHICLEID, DESTINATION, KILOMETERS) VALUES ('" + txtbox_VehicleID.Text + "', '" + txtbox_Destination.Text + "', '" + txtbox_NumberOfKilometers.Text + "')";
                //Displaying message to the user
                MessageBox.Show("Your Trip Details Has Been Saved!");
                //Creating an sql command and feeding the query and sql connection to it 
                SqlCommand sql = new SqlCommand(SQLquery2, connect);
                //Creating an sql data reader
                SqlDataReader sqlDataReader = sql.ExecuteReader();
                //Creating an sql data reader and assigning it
                SqlDataReader read = sqlDataReader;

                txtbox_VehicleID.Text = "";
                txtbox_Destination.Text = "";
                txtbox_NumberOfKilometers.Text = "";
              

            }
            catch (Exception er)
            {
                MessageBox.Show("Error!\n" +
                                "Make sure you entered all feilds correctly. \n" +
                                "" + er.Message);
            }
        }
    }
}
