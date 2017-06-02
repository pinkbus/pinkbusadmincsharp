using FastMember;
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
    public partial class frmTimeTable : Form
    {
        public frmTimeTable()
        {
            InitializeComponent();
        }
        com.somee.coachstationmanager.MyWebService ws;
        DataTable dt = new DataTable();
        private void frmTimeTable_Load(object sender, EventArgs e)
        {
            ws = new com.somee.coachstationmanager.MyWebService();
            dgvTabletimeList.DataSource = ws.GetListTimetable();
            dgvTabletimeList.Columns[0].HeaderText = "Nhân Viên";
            dgvTabletimeList.Columns[1].HeaderText = "Số Xe";
            dgvTabletimeList.Columns[2].HeaderText = "Mã Tuyến";
            dgvTabletimeList.Columns[3].HeaderText = "Trạng Thái";
            dgvTabletimeList.Columns[4].HeaderText = "Ngày Đi";
            dgvTabletimeList.ReadOnly = true;
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
         }
    }
}
