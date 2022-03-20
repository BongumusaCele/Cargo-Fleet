using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Configuration;

namespace Cargo_Fleet_Tracking
{
    public partial class VehicleStatusReport : Form
    {
        public VehicleStatusReport()
        {
            InitializeComponent();
        }

        private void VehicleStatusReport_Load(object sender, EventArgs e)
        {
            vehiclestatusdataGridView1.DataSource = GetVehicleReport();
        }

        private DataTable GetVehicleReport() 
        {
            DataTable dtVehicle = new DataTable();

            string conString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using(SqlConnection con = new SqlConnection(conString)) 
            {
                using(SqlCommand cmd = new SqlCommand("SELECT * FROM VEHICLE", con)) 
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtVehicle.Load(reader);
                }
            }

            return dtVehicle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewReports reports = new ViewReports();

            reports.Show();

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
