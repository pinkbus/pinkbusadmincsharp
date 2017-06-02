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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }
        com.somee.coachstationmanager.MyWebService ws;
        BindingSource bs = new BindingSource();
        byte[] imageBytes;
        private void frmCompany_Load(object sender, EventArgs e)
        {
            ws = new com.somee.coachstationmanager.MyWebService();
            BindingValues();
        }
        public void BindingValues()
        {
            bs.DataSource = ws.GetListCompany();
            tbCompany_id.DataBindings.Add(new Binding("Text", bs, "COMPANY_ID"));
            tbCompany_name.DataBindings.Add(new Binding("Text", bs, "COMPANY_NAME"));
            tbCompany_tel.DataBindings.Add(new Binding("Text", bs, "COMPANY_TEL"));
            pbCompany_pic.DataBindings.Add(new Binding("Image", bs, "COMPANY_PICTURE", true));
            pbCompany_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(ws.InsertCompany(tbCompany_id.Text, tbCompany_name.Text, tbCompany_tel.Text, imageBytes) == 1)
            {
                MessageBox.Show("ADDED");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);
                pbCompany_pic.Image = image;
                pbCompany_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                //
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    imageBytes = m.ToArray();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }
    }
}
