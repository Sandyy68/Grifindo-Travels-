
namespace Griffindo
{
    partial class LongtourHire_Form
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
            this.total_txt = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.enddate_dtp = new System.Windows.Forms.DateTimePicker();
            this.packagetype_cmb = new System.Windows.Forms.ComboBox();
            this.overnightstaycharge_txt = new System.Windows.Forms.TextBox();
            this.extrakmcharge_txt = new System.Windows.Forms.TextBox();
            this.endkmreading_txt = new System.Windows.Forms.TextBox();
            this.startkmreading_txt = new System.Windows.Forms.TextBox();
            this.basehirecharge_txt = new System.Windows.Forms.TextBox();
            this.vehicalno_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statrdate_dtp = new System.Windows.Forms.DateTimePicker();
            this.recid_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // total_txt
            // 
            this.total_txt.Location = new System.Drawing.Point(216, 262);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(168, 26);
            this.total_txt.TabIndex = 45;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 35);
            this.button5.TabIndex = 44;
            this.button5.Text = "Total";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // enddate_dtp
            // 
            this.enddate_dtp.CustomFormat = "yyyy/MM/dd - hh:mm:ss";
            this.enddate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enddate_dtp.Location = new System.Drawing.Point(762, 204);
            this.enddate_dtp.Name = "enddate_dtp";
            this.enddate_dtp.Size = new System.Drawing.Size(296, 26);
            this.enddate_dtp.TabIndex = 43;
            // 
            // packagetype_cmb
            // 
            this.packagetype_cmb.FormattingEnabled = true;
            this.packagetype_cmb.Items.AddRange(new object[] {
            "Airport_drop",
            "Airport_pic",
            "100KM",
            "200KM"});
            this.packagetype_cmb.Location = new System.Drawing.Point(762, 88);
            this.packagetype_cmb.Name = "packagetype_cmb";
            this.packagetype_cmb.Size = new System.Drawing.Size(296, 28);
            this.packagetype_cmb.TabIndex = 41;
            this.packagetype_cmb.SelectedIndexChanged += new System.EventHandler(this.packagetype_cmb_SelectedIndexChanged);
            // 
            // overnightstaycharge_txt
            // 
            this.overnightstaycharge_txt.Location = new System.Drawing.Point(216, 193);
            this.overnightstaycharge_txt.Name = "overnightstaycharge_txt";
            this.overnightstaycharge_txt.Size = new System.Drawing.Size(168, 26);
            this.overnightstaycharge_txt.TabIndex = 40;
            // 
            // extrakmcharge_txt
            // 
            this.extrakmcharge_txt.Location = new System.Drawing.Point(216, 124);
            this.extrakmcharge_txt.Name = "extrakmcharge_txt";
            this.extrakmcharge_txt.Size = new System.Drawing.Size(168, 26);
            this.extrakmcharge_txt.TabIndex = 39;
            // 
            // endkmreading_txt
            // 
            this.endkmreading_txt.Location = new System.Drawing.Point(762, 261);
            this.endkmreading_txt.Name = "endkmreading_txt";
            this.endkmreading_txt.Size = new System.Drawing.Size(296, 26);
            this.endkmreading_txt.TabIndex = 38;
            // 
            // startkmreading_txt
            // 
            this.startkmreading_txt.Location = new System.Drawing.Point(224, 261);
            this.startkmreading_txt.Name = "startkmreading_txt";
            this.startkmreading_txt.Size = new System.Drawing.Size(268, 26);
            this.startkmreading_txt.TabIndex = 37;
            // 
            // basehirecharge_txt
            // 
            this.basehirecharge_txt.Location = new System.Drawing.Point(216, 55);
            this.basehirecharge_txt.Name = "basehirecharge_txt";
            this.basehirecharge_txt.Size = new System.Drawing.Size(168, 26);
            this.basehirecharge_txt.TabIndex = 36;
            // 
            // vehicalno_txt
            // 
            this.vehicalno_txt.Location = new System.Drawing.Point(196, 147);
            this.vehicalno_txt.Name = "vehicalno_txt";
            this.vehicalno_txt.Size = new System.Drawing.Size(296, 26);
            this.vehicalno_txt.TabIndex = 35;
            this.vehicalno_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Extra km charge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "overnight_stay_charge";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Base hire charge ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "End km reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Start_Km_Reading :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Start_Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Package type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Vehicle_No : ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 35);
            this.button4.TabIndex = 49;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 32);
            this.button3.TabIndex = 48;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 32);
            this.button2.TabIndex = 47;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 46;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statrdate_dtp
            // 
            this.statrdate_dtp.CustomFormat = "yyyy/MM/dd - hh:mm:ss";
            this.statrdate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.statrdate_dtp.Location = new System.Drawing.Point(196, 204);
            this.statrdate_dtp.Name = "statrdate_dtp";
            this.statrdate_dtp.Size = new System.Drawing.Size(296, 26);
            this.statrdate_dtp.TabIndex = 42;
            this.statrdate_dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // recid_txt
            // 
            this.recid_txt.Location = new System.Drawing.Point(196, 90);
            this.recid_txt.Name = "recid_txt";
            this.recid_txt.Size = new System.Drawing.Size(296, 26);
            this.recid_txt.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Record_ID :";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(61, 351);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 35);
            this.button6.TabIndex = 52;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.total_txt);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.overnightstaycharge_txt);
            this.groupBox1.Controls.Add(this.extrakmcharge_txt);
            this.groupBox1.Controls.Add(this.basehirecharge_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(648, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 316);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation";
            // 
            // LongtourHire_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1096, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.recid_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enddate_dtp);
            this.Controls.Add(this.statrdate_dtp);
            this.Controls.Add(this.packagetype_cmb);
            this.Controls.Add(this.endkmreading_txt);
            this.Controls.Add(this.startkmreading_txt);
            this.Controls.Add(this.vehicalno_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LongtourHire_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Long Hire";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker enddate_dtp;
        private System.Windows.Forms.ComboBox packagetype_cmb;
        private System.Windows.Forms.TextBox overnightstaycharge_txt;
        private System.Windows.Forms.TextBox extrakmcharge_txt;
        private System.Windows.Forms.TextBox endkmreading_txt;
        private System.Windows.Forms.TextBox startkmreading_txt;
        private System.Windows.Forms.TextBox basehirecharge_txt;
        private System.Windows.Forms.TextBox vehicalno_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker statrdate_dtp;
        private System.Windows.Forms.TextBox recid_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}