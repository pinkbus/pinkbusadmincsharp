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
    public partial class frmCoachSeat : Form
    {
        public frmCoachSeat()
        {
            InitializeComponent();
        }
        com.somee.coachstationmanager.MyWebService ws;
        BindingSource bs = new BindingSource();
        private void frmCoachSeat_Load(object sender, EventArgs e)
        {
            ws = new com.somee.coachstationmanager.MyWebService();
            //cmbCoach.DataSource = ws.E_COACHToList().ToList();
            cmbCoach.ValueMember = "LICENSE_PLATE";
            cmbCoach.DisplayMember = "LICENSE_PLATE";
            BindingValues();
        }

        public void BindingValues()
        {
            //bs.DataSource = ws.D_SEATbyCOACHtoList(cmbCoach.SelectedValue.ToString()).ToList();
            tbSeat_id.DataBindings.Add(new Binding("Text", bs, "SEAT_ID"));
            tbSeat_id.DataBindings.Add(new Binding("Text", bs, "EXTRA_FEE"));
            tbSeat_id.DataBindings.Add(new Binding("Text", bs, "STATUS_SEAT"));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
