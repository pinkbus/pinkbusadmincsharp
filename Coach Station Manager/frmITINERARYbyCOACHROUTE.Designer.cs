namespace Coach_Station_Manager
{
    partial class frmITINERARYbyCOACHROUTE
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCoach_route = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDeparture_time = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbArrived_station = new System.Windows.Forms.ComboBox();
            this.cbDeparture_station = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tbArriavedTime = new System.Windows.Forms.TextBox();
            this.tbItinerary_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 31);
            this.label2.TabIndex = 70;
            this.label2.Text = "DANH SÁCH XE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Tuyến Xe";
            // 
            // cbCoach_route
            // 
            this.cbCoach_route.FormattingEnabled = true;
            this.cbCoach_route.Location = new System.Drawing.Point(72, 50);
            this.cbCoach_route.Name = "cbCoach_route";
            this.cbCoach_route.Size = new System.Drawing.Size(121, 21);
            this.cbCoach_route.TabIndex = 72;
            this.cbCoach_route.SelectedValueChanged += new System.EventHandler(this.cbCoach_route_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDeparture_time);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbArrived_station);
            this.groupBox1.Controls.Add(this.cbDeparture_station);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.tbArriavedTime);
            this.groupBox1.Controls.Add(this.tbItinerary_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 169);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbDeparture_time
            // 
            this.tbDeparture_time.Location = new System.Drawing.Point(232, 58);
            this.tbDeparture_time.Name = "tbDeparture_time";
            this.tbDeparture_time.Size = new System.Drawing.Size(118, 20);
            this.tbDeparture_time.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Giờ Đi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bến Đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bến ĐI";
            // 
            // cbArrived_station
            // 
            this.cbArrived_station.FormattingEnabled = true;
            this.cbArrived_station.Items.AddRange(new object[] {
            "Sai Gon",
            "Can Tho",
            "Vinh Long",
            "Sa Dec",
            "Cao Lanh"});
            this.cbArrived_station.Location = new System.Drawing.Point(14, 103);
            this.cbArrived_station.Name = "cbArrived_station";
            this.cbArrived_station.Size = new System.Drawing.Size(121, 21);
            this.cbArrived_station.TabIndex = 11;
            // 
            // cbDeparture_station
            // 
            this.cbDeparture_station.FormattingEnabled = true;
            this.cbDeparture_station.Items.AddRange(new object[] {
            "Can Tho",
            "Dong Thap",
            "Sai Gon",
            "Vinh Long"});
            this.cbDeparture_station.Location = new System.Drawing.Point(14, 57);
            this.cbDeparture_station.Name = "cbDeparture_station";
            this.cbDeparture_station.Size = new System.Drawing.Size(121, 21);
            this.cbDeparture_station.TabIndex = 10;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(190, 140);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(109, 140);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // tbArriavedTime
            // 
            this.tbArriavedTime.Location = new System.Drawing.Point(232, 104);
            this.tbArriavedTime.Name = "tbArriavedTime";
            this.tbArriavedTime.Size = new System.Drawing.Size(121, 20);
            this.tbArriavedTime.TabIndex = 6;
            // 
            // tbItinerary_name
            // 
            this.tbItinerary_name.Location = new System.Drawing.Point(137, 19);
            this.tbItinerary_name.Name = "tbItinerary_name";
            this.tbItinerary_name.Size = new System.Drawing.Size(100, 20);
            this.tbItinerary_name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giờ Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên lộ Trình";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Image = global::Coach_Station_Manager.Properties.Resources.Them;
            this.btnThem.Location = new System.Drawing.Point(49, 286);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 68);
            this.btnThem.TabIndex = 76;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Image = global::Coach_Station_Manager.Properties.Resources.Thoat;
            this.btnThoat.Location = new System.Drawing.Point(286, 286);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(73, 68);
            this.btnThoat.TabIndex = 75;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Image = global::Coach_Station_Manager.Properties.Resources.Xoa;
            this.btnXoa.Location = new System.Drawing.Point(169, 286);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 68);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // frmITINERARYbyCOACHROUTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 410);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCoach_route);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmITINERARYbyCOACHROUTE";
            this.Text = "ALL ITINERARY by COACH ROUTE";
            this.Load += new System.EventHandler(this.frmITINERARYbyCOACHROUTE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCoach_route;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbArrived_station;
        private System.Windows.Forms.ComboBox cbDeparture_station;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox tbArriavedTime;
        private System.Windows.Forms.TextBox tbItinerary_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tbDeparture_time;
        private System.Windows.Forms.Label label9;
    }
}