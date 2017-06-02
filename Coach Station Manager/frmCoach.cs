using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Station_Manager
{
    public partial class frmCoach : Form
    {
        public frmCoach()
        {
            InitializeComponent();
        }
        com.somee.coachstationmanager.MyWebService ws;
        BindingSource bs = new BindingSource();
        byte[] imageBytes;
        private void frmCoach_Load(object sender, EventArgs e)
        {
            ws = new com.somee.coachstationmanager.MyWebService();
           
            BindingValues();
        }
        public void BindingValues()
        {
            bs.DataSource = ws.GetListCoach();
            tbLicense_plate.DataBindings.Add(new Binding("Text", bs, "LICENSE_PLATE"));
            tbCatagory.DataBindings.Add(new Binding("Text", bs, "TYPE_SEAT"));
            tbTotal_seat.DataBindings.Add(new Binding("Text", bs, "TOTAL_SEATS"));
            tb_extraFee.DataBindings.Add(new Binding("Text", bs, "EXTRA_FEE"));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            Int32.TryParse(tbTotal_seat.Text,out x);
            Int32.TryParse(tb_extraFee.Text, out y);
            if(ws.InsertCoach(tbLicense_plate.Text,tbTotal_seat.Text,x,y)==1)
            {
                MessageBox.Show("ADDED");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
          
        }
    }
}
