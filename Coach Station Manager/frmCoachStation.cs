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
    public partial class frmCoachStation : Form
    {
        public frmCoachStation()
        {
            InitializeComponent();
        }
        com.somee.coachstationmanager.MyWebService ws;
        BindingSource bs = new BindingSource();
        byte[] imageBytes;
        private void frmCoachStation_Load(object sender, EventArgs e)
        {
            ws = new com.somee.coachstationmanager.MyWebService();
            BindingValues();
            
        }
        public void BindingValues()
        {
            bs.DataSource = ws.GetListCoachStation();
            tbCoach_station_id.DataBindings.Add(new Binding("Text", bs, "COACH_STATION_ID"));
            tbCoach_station_name.DataBindings.Add(new Binding("Text", bs, "COACH_STATION_NAME"));
            tbCoach_staion_address.DataBindings.Add(new Binding("Text", bs, "COACH_STATION_ADDRESS"));
            tbCoach_station_tel.DataBindings.Add(new Binding("Text", bs, "COACH_STATION_TEL"));
            pbCoach_station_pic.DataBindings.Add(new Binding("Image", bs, "COACH_STATION_PICTURE", true));
            tv_City.DataBindings.Add(new Binding("Text", bs, "CITY"));
            pbCoach_station_pic.SizeMode = PictureBoxSizeMode.StretchImage;
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
            if (ws.InsertCoachStation(tbCoach_station_id.Text, tbCoach_station_name.Text,
                tbCoach_staion_address.Text, tbCoach_station_tel.Text, imageBytes, tv_City.Text) == 1)
            {
                MessageBox.Show("ADDED");
            }
            else
                MessageBox.Show("ERROR");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);
                pbCoach_station_pic.Image = image;
                pbCoach_station_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                //
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    imageBytes = m.ToArray();
                }
            }
        }
    }
}
