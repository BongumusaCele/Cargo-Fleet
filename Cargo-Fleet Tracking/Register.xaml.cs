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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        //Declaring connection string
        public static string connectionStr = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\School\Diploma in Information Technology in Software Development\Second Year\Semester 2\Work Integrated Learning 2\POE\5 Implementation\Cargo-Fleet Tracking\Cargo-Fleet Tracking\Cargo-Fleet_Database.mdf;Integrated Security = True";
        //Establishing a sql connection 
        SqlConnection connect = new SqlConnection(connectionStr);

        public Register()
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
            try
            {
                ////Declaring a variable to store password
                //string passwordS = txtbox_Password.Text;
                ////Declaring a variable to store username
                //string username = txtbox_Username.Text;
                ////Declaring a variable to store hashed password
                //string hashedPassword = Encrypt(passwordS);

                //using (SqlConnection constr = new SqlConnection(connectionStr))
                //{
                //    constr.Open();

                //    SqlCommand sqlCom = new SqlCommand("USERADD", constr);
                //    sqlCom.CommandType = System.Data.CommandType.StoredProcedure;
                //    sqlCom.Parameters.AddWithValue("@USERNAME", txtbox_Username.Text.Trim());
                //    sqlCom.Parameters.AddWithValue("@PASSWORD", hashedPassword.Trim());

                //    sqlCom.ExecuteNonQuery();

                //    MessageBox.Show("Registration Complete!");

                //    txtbox_Password.Clear();
                //    txtbox_Username.Clear();

                //}

                //Declaring a string to store sql query code
                string SQLquery2 = "INSERT INTO USERS (USERNAME, PASSWORD) VALUES ('" + txtbox_username.Text + "', '" + txtbox_password.Text + "')";
                //Displaying message to the user
                MessageBox.Show("You Have Been Registered!");
                //Creating an sql command and feeding the query and sql connection to it 
                SqlCommand sql = new SqlCommand(SQLquery2, connect);
                //Creating an sql data reader
                SqlDataReader sqlDataReader = sql.ExecuteReader();
                //Creating an sql data reader and assigning it
                SqlDataReader read = sqlDataReader;

                MainWindow goLogin = new MainWindow();

                goLogin.Show();

                Hide();

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
