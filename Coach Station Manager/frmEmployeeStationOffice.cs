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
    public partial class frmEmployeeStationOffice : Form
    {
        public frmEmployeeStationOffice()
        {
            InitializeComponent();
        }
        byte[] imageBytes = null;
        com.somee.coachstationmanager.MyWebService ws;
        BindingSource bs = new BindingSource();
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);
                pbAvatar.Image = image;
                pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                //
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if(ws.InsertEmployee(tbEmployye_id.Text,tbEmployee_namee.Text,tbEmployee_tel.Text,tbPosition.Text,
               imageBytes,cmbCompany.SelectedValue.ToString(),cbCoach.SelectedValue.ToString(),AutoPass())==1)
            {
                MessageBox.Show("ADDED");
            }
           else
            {
                MessageBox.Show("ERROR");
            }

            
        }
        private string AutoPass()
        {
            return "matkhau123";
        }
        private void frmEmployeeStationOffice_Load(object sender, EventArgs e)
        {
            ws = new com.somee.coachstationmanager.MyWebService();
            BindCombobox();
            BindValues();
        }
        public void BindCombobox()
        {
            cmbCompany.DataSource = ws.GetListCompany();
            cmbCompany.ValueMember = "COMPANY_ID";
            cmbCompany.DisplayMember = "COMPANY_NAME";
            cbCoach.DataSource = ws.GetListCoach();
            cbCoach.ValueMember = "LICENSE_PLATE";
            cbCoach.DisplayMember = "LICENSE_PLATE";


        }
        public void BindValues()
        {
            bs.DataSource = ws.GetListEmployeebyCompany(cmbCompany.SelectedValue.ToString());
            tbEmployye_id.DataBindings.Add(new Binding("Text", bs, "EMPLOYEE_ID"));
            tbEmployee_namee.DataBindings.Add(new Binding("Text", bs, "EMPLOYEE_NAME"));
            tbEmployee_tel.DataBindings.Add(new Binding("Text", bs, "EMPLOYEE_TEL"));
            tbPosition.DataBindings.Add(new Binding("Text", bs, "POSITION"));
            pbAvatar.DataBindings.Add(new Binding("Image", bs, "EMPLOYEE_PICUTURE", true));
            cbCoach.DataBindings.Add(new Binding("Text", bs, "LICENSE_PLATE", true));
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void cmbCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            bs.DataSource = ws.GetListEmployeebyCompany(cmbCompany.SelectedValue.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ws.UpdateEmployee(tbEmployye_id.Text, imageBytes, cbCoach.SelectedValue.ToString());
        }
    }
}
