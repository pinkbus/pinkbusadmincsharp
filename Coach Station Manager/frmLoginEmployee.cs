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
    
    public partial class frmLoginEmployee : Form
    {
        public frmLoginEmployee()
        {
            InitializeComponent();
        }
        private frmMain frmmain;
        public frmLoginEmployee(frmMain frm)
            : this()
        {
            frmmain = frm;
        }
        com.somee.coachstationmanager.MyWebService ws; 
        private void frmLoginEmployee_Load(object sender, EventArgs e)
        {
           ws= new com.somee.coachstationmanager.MyWebService();
            cbmCompany.DataSource = ws.GetListCompany();
            cbmCompany.ValueMember = "COMPANY_ID";
            cbmCompany.DisplayMember = "COMPANY_NAME";
            txtMatKhau.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(ws.LOGINforEMPLOYEE(txtTenDangNhap.Text,txtMatKhau.Text,cbmCompany.SelectedValue.ToString())==1)
            {
                ws.UpdateTimeTable(cbmCompany.SelectedValue.ToString());
                Data.companyid = cbmCompany.SelectedValue.ToString();
                Data.isLogin = true;
                MessageBox.Show("SUCCESS!"+Data.companyid+Data.isLogin.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR!! PLEASE TRY AGAIN");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
