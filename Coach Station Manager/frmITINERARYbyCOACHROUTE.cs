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
    public partial class frmITINERARYbyCOACHROUTE : Form
    {
        public frmITINERARYbyCOACHROUTE()
        {
            InitializeComponent();
        }
        com.somee.coachstationmanager.MyWebService ws;
        BindingSource bs = new BindingSource();
        private void frmITINERARYbyCOACHROUTE_Load(object sender, EventArgs e)
        {
            ws = new com.somee.coachstationmanager.MyWebService();
            cbCoach_route.DataSource = ws.GetListCoachRoute();
            cbCoach_route.ValueMember = "COACH_ROUTE_ID";
            cbCoach_route.DisplayMember = "COACH_ROUTE_NAME";
            BindingValues();
        }
        public void BindingValues()
        {
            bs.DataSource = ws.GetListItinerary(cbCoach_route.SelectedValue.ToString());
            tbItinerary_name.DataBindings.Add(new Binding("Text", bs, "ITINERARY_NAME"));
            tbArriavedTime.DataBindings.Add(new Binding("Text", bs, "END_TIME"));
            cbDeparture_station.DataBindings.Add(new Binding("Text", bs, "BOARDING"));
            cbArrived_station.DataBindings.Add(new Binding("Text", bs, "DROPPING"));
            tbDeparture_time.DataBindings.Add(new Binding("Text", bs, "START_TIME"));
        }

        private void cbCoach_route_SelectedValueChanged(object sender, EventArgs e)
        {
            bs.DataSource = ws.GetListItinerary(cbCoach_route.SelectedValue.ToString());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
