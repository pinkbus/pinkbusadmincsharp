namespace Coach_Station_Manager
{
    partial class frmCoachStationOffice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoachStation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreviour = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbOfficeName = new System.Windows.Forms.TextBox();
            this.tbOfficeTel = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.pbCoachStation = new System.Windows.Forms.PictureBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoachStation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Chọn Bến Xe";
            // 
            // cmbCoachStation
            // 
            this.cmbCoachStation.FormattingEnabled = true;
            this.cmbCoachStation.Location = new System.Drawing.Point(185, 40);
            this.cmbCoachStation.Name = "cmbCoachStation";
            this.cmbCoachStation.Size = new System.Drawing.Size(121, 21);
            this.cmbCoachStation.TabIndex = 77;
            this.cmbCoachStation.SelectedValueChanged += new System.EventHandler(this.cmbCoachStation_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 31);
            this.label2.TabIndex = 82;
            this.label2.Text = "DANH SÁCH NHÀ XE THEO BẾN";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Image = global::Coach_Station_Manager.Properties.Resources.Them;
            this.btnAdd.Location = new System.Drawing.Point(67, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 68);
            this.btnAdd.TabIndex = 81;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::Coach_Station_Manager.Properties.Resources.Thoat;
            this.btnClose.Location = new System.Drawing.Point(304, 207);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 68);
            this.btnClose.TabIndex = 80;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Image = global::Coach_Station_Manager.Properties.Resources.Xoa;
            this.btnDel.Location = new System.Drawing.Point(187, 207);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(73, 68);
            this.btnDel.TabIndex = 79;
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPreviour);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.tbOfficeName);
            this.groupBox1.Controls.Add(this.tbOfficeTel);
            this.groupBox1.Controls.Add(this.lbTel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCoachStation);
            this.groupBox1.Controls.Add(this.cbCompany);
            this.groupBox1.Location = new System.Drawing.Point(45, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 141);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnPreviour
            // 
            this.btnPreviour.Location = new System.Drawing.Point(10, 104);
            this.btnPreviour.Name = "btnPreviour";
            this.btnPreviour.Size = new System.Drawing.Size(75, 23);
            this.btnPreviour.TabIndex = 85;
            this.btnPreviour.Text = "<";
            this.btnPreviour.UseVisualStyleBackColor = true;
            this.btnPreviour.Click += new System.EventHandler(this.btnPreviour_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(91, 104);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 85;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbOfficeName
            // 
            this.tbOfficeName.Location = new System.Drawing.Point(11, 36);
            this.tbOfficeName.Name = "tbOfficeName";
            this.tbOfficeName.Size = new System.Drawing.Size(100, 20);
            this.tbOfficeName.TabIndex = 4;
            // 
            // tbOfficeTel
            // 
            this.tbOfficeTel.Location = new System.Drawing.Point(11, 78);
            this.tbOfficeTel.Name = "tbOfficeTel";
            this.tbOfficeTel.Size = new System.Drawing.Size(100, 20);
            this.tbOfficeTel.TabIndex = 4;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(8, 62);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(75, 13);
            this.lbTel.TabIndex = 2;
            this.lbTel.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Chọn Hãng Xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Văn Phòng";
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(185, 80);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(121, 21);
            this.cbCompany.TabIndex = 77;
            this.cbCompany.SelectedValueChanged += new System.EventHandler(this.cbCompany_SelectedValueChanged);
            // 
            // pbCoachStation
            // 
            this.pbCoachStation.Location = new System.Drawing.Point(440, 43);
            this.pbCoachStation.Name = "pbCoachStation";
            this.pbCoachStation.Size = new System.Drawing.Size(198, 176);
            this.pbCoachStation.TabIndex = 84;
            this.pbCoachStation.TabStop = false;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(494, 230);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 85;
            this.btnBrowser.Text = "Thêm Hình";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCoachStationOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 369);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.pbCoachStation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Name = "frmCoachStationOffice";
            this.Text = "All Coach Station Office On Coach Station";
            this.Load += new System.EventHandler(this.frmCoachStationOffice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoachStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCoachStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbOfficeName;
        private System.Windows.Forms.TextBox tbOfficeTel;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbCoachStation;
        private System.Windows.Forms.Button btnPreviour;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCompany;
    }
}