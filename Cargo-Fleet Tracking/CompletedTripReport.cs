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
    public partial class CompletedTripReport : Form
    {
        public CompletedTripReport()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ViewReports reports = new ViewReports();

            reports.Show();

            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CompletedTripReport_Load(object sender, EventArgs e)
        {
            plannedtripreportdataGridView1.DataSource = GetPlannedTripReport();
        }

        private DataTable GetPlannedTripReport()
        {
            DataTable dtPlannedTrip = new DataTable();

            string conString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TRIPS", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtPlannedTrip.Load(reader);
                }
            }

            return dtPlannedTrip;
        }
    }
}
