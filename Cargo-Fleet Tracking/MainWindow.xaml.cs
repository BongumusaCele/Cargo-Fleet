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
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace Cargo_Fleet_Tracking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaring connection string
        public static string connectionStr = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\School\Diploma in Information Technology in Software Development\Second Year\Semester 2\Work Integrated Learning 2\POE\5 Implementation\Cargo-Fleet Tracking\Cargo-Fleet Tracking\Cargo-Fleet_Database.mdf;Integrated Security = True";
                                               
        //Establishing a sql connection 
        SqlConnection connect = new SqlConnection(connectionStr);

        public MainWindow()
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

        private void btn_Register_Click(object sender, RoutedEventArgs e)
        {
            Register goRegister = new Register();

            goRegister.Show();

            Hide();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {

            ////Declaring a variable to store password
            //string passwordS = txtbox_Password.Text;
            ////Declaring a variable to store username
            //string username = txtbox_Username.Text;
            ////Declaring a variable to store hashed password
            //string hashedPassword = Encrypt(passwordS);

            //Declaring a string to store sql query code
            string SQLquery = "Select* from USERS where USERNAME='" + txtbox_Username.Text.Trim() + "' and PASSWORD= '" + txtbox_Password.Text.Trim() + "'";
            //Creating data adapter and feeding it sql query and sql connection
            SqlDataAdapter dt = new SqlDataAdapter(SQLquery, connect);
            //Creating an object of data table
            DataTable table = new DataTable();
            //Filling the data table with data from sql database
            dt.Fill(table);

            //if statement to verify password and username
            if (table.Rows.Count == 1)
            {
                Menu gotoMenu = new Menu();

                gotoMenu.Show();

                Hide();
            }
            else
            {
                //Displaying error message
                MessageBox.Show("Enter a correct password and username or register");
            }
            
        }
    }
}
