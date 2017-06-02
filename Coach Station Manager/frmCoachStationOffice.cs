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
    public partial class frmCoachStationOffice : Form
    {
        public frmCoachStationOffice()
        {
            InitializeComponent();
        }
        com.somee.coachstationmanager.MyWebService ws;
        BindingSource bs = new BindingSource();
        byte[] imageBytes = null;
        private void frmCoachStationOffice_Load(object sender, EventArgs e)
        {
            ws = new com.somee.coachstationmanager.MyWebService();
            //bs.DataSource = ws.B_STATIONOFFICEListbyCOACHSTATion("BXCT").ToList();
            cmbCoachStation.DataSource = ws.GetListCoachStation();
            cmbCoachStation.ValueMember = "COACH_STATION_ID";
            cmbCoachStation.DisplayMember = "COACH_STATION_NAME";
            cmbCoachStation.SelectedIndex = 0;
            cbCompany.DataSource = ws.GetListCompany();
            cbCompany.ValueMember = "COMPANY_ID";
            cbCompany.DisplayMember = "COMPANY_NAME";
            cbCompany.SelectedIndex = 0;
            BindValues();

        }
        public void BindValues()
        {
            tbOfficeName.DataBindings.Add(new Binding("Text", bs, "OFFICE_NAME"));
            tbOfficeTel.DataBindings.Add(new Binding("Text", bs, "OFFICE_TEL"));
            pbCoachStation.DataBindings.Add(new Binding("Image", bs, "OFFICE_PICTURE", true));
            cmbCoachStation.DataBindings.Add(new Binding("Text", bs, "COACH_STATION_ID"));
            cbCompany.DataBindings.Add(new Binding("Text", bs, "COMPANY_ID"));
            pbCoachStation.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnPreviour_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (ws.InsertBrandOffice(cmbCoachStation.SelectedValue.ToString(),
                cbCompany.SelectedValue.ToString(), tbOfficeName.Text, tbOfficeTel.Text, imageBytes) == 1)
                MessageBox.Show("ADDED");
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result==DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);
                pbCoachStation.Image = image;
                pbCoachStation.SizeMode = PictureBoxSizeMode.StretchImage;
                //
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    imageBytes = m.ToArray();
                    

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    MessageBox.Show(base64String);
                }
            }
        }

        private void cmbCoachStation_SelectedValueChanged(object sender, EventArgs e)
        {
            bs.DataSource = ws.GetListOfficebyCoachStation(cmbCoachStation.SelectedValue.ToString());
            
            
        }

        private void cbCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            bs.DataSource = ws.GetListOfficebyCompany(cbCompany.SelectedValue.ToString());
        }
    }
}
