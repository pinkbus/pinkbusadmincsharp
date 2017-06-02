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
    public partial class frmCoachRoute : Form
    {
        public frmCoachRoute()
        {
            InitializeComponent();
        }
        com.somee.coachstationmanager.MyWebService ws;
        BindingSource bs = new BindingSource();
        private void frmCoachRoute_Load(object sender, EventArgs e)
        {
            ws = new com.somee.coachstationmanager.MyWebService();
            BindingValues();
        }
        public void BindingValues()
        {
            bs.DataSource = ws.GetListCoachRoute();
            tbCoach_route_id.DataBindings.Add(new Binding("Text", bs, "COACH_ROUTE_ID"));
            tbCoach_route_name.DataBindings.Add(new Binding("Text", bs, "COACH_ROUTE_NAME"));
            tbPrice.DataBindings.Add(new Binding("Text", bs, "COACH_ROUTE_PRICE"));
            tbRouteTime.DataBindings.Add(new Binding("Text", bs, "ROUTE_TIME"));
            tbDepartureTime.DataBindings.Add(new Binding("Text", bs, "DEPARTURE_TIME"));
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int p = 0;
            int r = 0;
            Int32.TryParse(tbRouteTime.Text, out r);
            Int32.TryParse(tbPrice.Text, out p);
            if (ws.InsertCoachRoute(tbCoach_route_id.Text, tbCoach_route_name.Text, p, tbDepartureTime.Text, r) == 1)
                MessageBox.Show("ADDED");
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
