using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cargo_Fleet_Tracking
{
    public partial class AppointmentReport : Form
    {
        public AppointmentReport()
        {
            InitializeComponent();
        }

        private void AppointmentReport_Load(object sender, EventArgs e)
        {
            appointmentreportdataGridView1.DataSource = GetAppointmentReport();
        }

        private DataTable GetAppointmentReport()
        {
            DataTable dtAppointment = new DataTable();

            string conString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM APPOINTMENTS", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtAppointment.Load(reader);
                }
            }

            return dtAppointment;
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
