using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Station_Manager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            com.somee.coachstationmanager.MyWebService ws = new com.somee.coachstationmanager.MyWebService();
            frmLoginEmployee f = new frmLoginEmployee();
            f.ShowDialog();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmLoginEmployee f = new frmLoginEmployee();
            f.ShowDialog();
        }

        private void btnCoachStation_Click(object sender, EventArgs e)
        {
            frmCoachStation f = new frmCoachStation();
            f.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeStationOffice f = new frmEmployeeStationOffice();
            f.ShowDialog();
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCoach_Click(object sender, EventArgs e)
        {
            frmCoach f = new frmCoach();
            f.ShowDialog();
        }

        private void btnStationOffice_Click(object sender, EventArgs e)
        {
            frmCoachStationOffice f = new frmCoachStationOffice();
            f.ShowDialog();
        }

        private void btnCoachroute_Click(object sender, EventArgs e)
        {
            frmCoachRoute f = new frmCoachRoute();
            f.ShowDialog();
        }

        private void btnTabletime_Click(object sender, EventArgs e)
        {
            frmTimeTable f = new frmTimeTable();
            f.ShowDialog();
        }

        private void btnItinerary_Click(object sender, EventArgs e)
        {
            frmITINERARYbyCOACHROUTE f = new frmITINERARYbyCOACHROUTE();
            f.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmCompany frm = new frmCompany();
            frm.ShowDialog();
        }
    }
}
