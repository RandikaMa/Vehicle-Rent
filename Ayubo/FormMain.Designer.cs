namespace Ayubo
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.vehicle = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cus_tp = new System.Windows.Forms.TextBox();
            this.cus_add = new System.Windows.Forms.TextBox();
            this.cus_nic = new System.Windows.Forms.TextBox();
            this.cusnm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Addrss = new System.Windows.Forms.Label();
            this.nic = new System.Windows.Forms.Label();
            this.Cus_name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wthdrvr = new System.Windows.Forms.CheckBox();
            this.pckge = new System.Windows.Forms.ComboBox();
            this.rtrndt = new System.Windows.Forms.DateTimePicker();
            this.rntdt = new System.Windows.Forms.DateTimePicker();
            this.lbl_vhcl = new System.Windows.Forms.ComboBox();
            this.vhcl_no = new System.Windows.Forms.Label();
            this.package = new System.Windows.Forms.Label();
            this.rnt_dt = new System.Windows.Forms.Label();
            this.rtn_dt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.strtkm = new System.Windows.Forms.TextBox();
            this.endkm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mxkm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceKM = new System.Windows.Forms.TextBox();
            this.Calculation = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totchrge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.waitingchrge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.extrachrge = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Calculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.vehicle);
            this.panel1.Controls.Add(this.home);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 613);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(112, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vehicle
            // 
            this.vehicle.BackColor = System.Drawing.Color.Yellow;
            this.vehicle.Location = new System.Drawing.Point(112, 298);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(160, 35);
            this.vehicle.TabIndex = 0;
            this.vehicle.Text = "Add Vehicle";
            this.vehicle.UseVisualStyleBackColor = false;
            this.vehicle.Click += new System.EventHandler(this.button1_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Yellow;
            this.home.Location = new System.Drawing.Point(112, 232);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(160, 35);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Calculation);
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(279, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 601);
            this.panel2.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(746, 537);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(109, 61);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.cus_tp);
            this.groupBox2.Controls.Add(this.cus_add);
            this.groupBox2.Controls.Add(this.cus_nic);
            this.groupBox2.Controls.Add(this.cusnm);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Addrss);
            this.groupBox2.Controls.Add(this.nic);
            this.groupBox2.Controls.Add(this.Cus_name);
            this.groupBox2.Font = new System.Drawing.Font("Felix Titling", 12F);
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // cus_tp
            // 
            this.cus_tp.Location = new System.Drawing.Point(234, 220);
            this.cus_tp.Name = "cus_tp";
            this.cus_tp.Size = new System.Drawing.Size(215, 26);
            this.cus_tp.TabIndex = 1;
            // 
            // cus_add
            // 
            this.cus_add.Location = new System.Drawing.Point(234, 176);
            this.cus_add.Name = "cus_add";
            this.cus_add.Size = new System.Drawing.Size(215, 26);
            this.cus_add.TabIndex = 1;
            // 
            // cus_nic
            // 
            this.cus_nic.Location = new System.Drawing.Point(234, 124);
            this.cus_nic.Name = "cus_nic";
            this.cus_nic.Size = new System.Drawing.Size(215, 26);
            this.cus_nic.TabIndex = 1;
            // 
            // cusnm
            // 
            this.cusnm.Location = new System.Drawing.Point(234, 78);
            this.cusnm.Name = "cusnm";
            this.cusnm.Size = new System.Drawing.Size(215, 26);
            this.cusnm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone No:";
            // 
            // Addrss
            // 
            this.Addrss.AutoSize = true;
            this.Addrss.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.Addrss.Location = new System.Drawing.Point(6, 182);
            this.Addrss.Name = "Addrss";
            this.Addrss.Size = new System.Drawing.Size(62, 15);
            this.Addrss.TabIndex = 0;
            this.Addrss.Text = "Address:";
            // 
            // nic
            // 
            this.nic.AutoSize = true;
            this.nic.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.nic.Location = new System.Drawing.Point(6, 135);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(32, 15);
            this.nic.TabIndex = 0;
            this.nic.Text = "NIC:";
            this.nic.Click += new System.EventHandler(this.nic_Click);
            // 
            // Cus_name
            // 
            this.Cus_name.AutoSize = true;
            this.Cus_name.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.Cus_name.Location = new System.Drawing.Point(6, 89);
            this.Cus_name.Name = "Cus_name";
            this.Cus_name.Size = new System.Drawing.Size(112, 15);
            this.Cus_name.TabIndex = 0;
            this.Cus_name.Text = "Customer Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.PriceKM);
            this.groupBox1.Controls.Add(this.mxkm);
            this.groupBox1.Controls.Add(this.endkm);
            this.groupBox1.Controls.Add(this.strtkm);
            this.groupBox1.Controls.Add(this.wthdrvr);
            this.groupBox1.Controls.Add(this.pckge);
            this.groupBox1.Controls.Add(this.rtrndt);
            this.groupBox1.Controls.Add(this.rntdt);
            this.groupBox1.Controls.Add(this.lbl_vhcl);
            this.groupBox1.Controls.Add(this.vhcl_no);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.package);
            this.groupBox1.Controls.Add(this.rnt_dt);
            this.groupBox1.Controls.Add(this.rtn_dt);
            this.groupBox1.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 586);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // wthdrvr
            // 
            this.wthdrvr.AutoSize = true;
            this.wthdrvr.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wthdrvr.Location = new System.Drawing.Point(246, 25);
            this.wthdrvr.Name = "wthdrvr";
            this.wthdrvr.Size = new System.Drawing.Size(112, 24);
            this.wthdrvr.TabIndex = 5;
            this.wthdrvr.Text = "With Driver";
            this.wthdrvr.UseVisualStyleBackColor = true;
            // 
            // pckge
            // 
            this.pckge.FormattingEnabled = true;
            this.pckge.Location = new System.Drawing.Point(147, 219);
            this.pckge.Name = "pckge";
            this.pckge.Size = new System.Drawing.Size(200, 27);
            this.pckge.TabIndex = 4;
            this.pckge.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // rtrndt
            // 
            this.rtrndt.Location = new System.Drawing.Point(147, 161);
            this.rtrndt.Name = "rtrndt";
            this.rtrndt.Size = new System.Drawing.Size(200, 26);
            this.rtrndt.TabIndex = 3;
            // 
            // rntdt
            // 
            this.rntdt.Location = new System.Drawing.Point(147, 110);
            this.rntdt.Name = "rntdt";
            this.rntdt.Size = new System.Drawing.Size(200, 26);
            this.rntdt.TabIndex = 2;
            // 
            // lbl_vhcl
            // 
            this.lbl_vhcl.FormattingEnabled = true;
            this.lbl_vhcl.Location = new System.Drawing.Point(147, 56);
            this.lbl_vhcl.Name = "lbl_vhcl";
            this.lbl_vhcl.Size = new System.Drawing.Size(200, 27);
            this.lbl_vhcl.TabIndex = 1;
            // 
            // vhcl_no
            // 
            this.vhcl_no.AutoSize = true;
            this.vhcl_no.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vhcl_no.Location = new System.Drawing.Point(8, 68);
            this.vhcl_no.Name = "vhcl_no";
            this.vhcl_no.Size = new System.Drawing.Size(77, 15);
            this.vhcl_no.TabIndex = 0;
            this.vhcl_no.Text = "Vehicle No:";
            // 
            // package
            // 
            this.package.AutoSize = true;
            this.package.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.package.Location = new System.Drawing.Point(8, 231);
            this.package.Name = "package";
            this.package.Size = new System.Drawing.Size(61, 15);
            this.package.TabIndex = 0;
            this.package.Text = "Package:";
            this.package.Click += new System.EventHandler(this.label1_Click);
            // 
            // rnt_dt
            // 
            this.rnt_dt.AutoSize = true;
            this.rnt_dt.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.rnt_dt.Location = new System.Drawing.Point(8, 119);
            this.rnt_dt.Name = "rnt_dt";
            this.rnt_dt.Size = new System.Drawing.Size(73, 15);
            this.rnt_dt.TabIndex = 0;
            this.rnt_dt.Text = "Rent Date:";
            this.rnt_dt.Click += new System.EventHandler(this.rnt_dt_Click);
            // 
            // rtn_dt
            // 
            this.rtn_dt.AutoSize = true;
            this.rtn_dt.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.rtn_dt.Location = new System.Drawing.Point(8, 170);
            this.rtn_dt.Name = "rtn_dt";
            this.rtn_dt.Size = new System.Drawing.Size(86, 15);
            this.rtn_dt.TabIndex = 0;
            this.rtn_dt.Text = "Return Date:";
            this.rtn_dt.Click += new System.EventHandler(this.rtn_dt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.label2.Location = new System.Drawing.Point(8, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start KM";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.label3.Location = new System.Drawing.Point(8, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "End KM";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // strtkm
            // 
            this.strtkm.Location = new System.Drawing.Point(147, 279);
            this.strtkm.Name = "strtkm";
            this.strtkm.Size = new System.Drawing.Size(200, 26);
            this.strtkm.TabIndex = 6;
            // 
            // endkm
            // 
            this.endkm.Location = new System.Drawing.Point(147, 336);
            this.endkm.Name = "endkm";
            this.endkm.Size = new System.Drawing.Size(200, 26);
            this.endkm.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.label4.Location = new System.Drawing.Point(8, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Max KM";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // mxkm
            // 
            this.mxkm.Location = new System.Drawing.Point(147, 400);
            this.mxkm.Name = "mxkm";
            this.mxkm.Size = new System.Drawing.Size(200, 26);
            this.mxkm.TabIndex = 6;
            this.mxkm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.label5.Location = new System.Drawing.Point(8, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Per KM";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // PriceKM
            // 
            this.PriceKM.Location = new System.Drawing.Point(147, 463);
            this.PriceKM.Name = "PriceKM";
            this.PriceKM.Size = new System.Drawing.Size(200, 26);
            this.PriceKM.TabIndex = 6;
            this.PriceKM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Calculation
            // 
            this.Calculation.BackColor = System.Drawing.Color.Silver;
            this.Calculation.Controls.Add(this.extrachrge);
            this.Calculation.Controls.Add(this.label8);
            this.Calculation.Controls.Add(this.waitingchrge);
            this.Calculation.Controls.Add(this.label7);
            this.Calculation.Controls.Add(this.totchrge);
            this.Calculation.Controls.Add(this.label6);
            this.Calculation.Location = new System.Drawing.Point(374, 329);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(481, 202);
            this.Calculation.TabIndex = 4;
            this.Calculation.TabStop = false;
            this.Calculation.Text = "Calculation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tota Charge";
            // 
            // totchrge
            // 
            this.totchrge.Location = new System.Drawing.Point(188, 23);
            this.totchrge.Name = "totchrge";
            this.totchrge.Size = new System.Drawing.Size(261, 20);
            this.totchrge.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Waiting Charge";
            // 
            // waitingchrge
            // 
            this.waitingchrge.Location = new System.Drawing.Point(188, 60);
            this.waitingchrge.Name = "waitingchrge";
            this.waitingchrge.Size = new System.Drawing.Size(261, 20);
            this.waitingchrge.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Extra Charge";
            // 
            // extrachrge
            // 
            this.extrachrge.Location = new System.Drawing.Point(188, 103);
            this.extrachrge.Name = "extrachrge";
            this.extrachrge.Size = new System.Drawing.Size(261, 20);
            this.extrachrge.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Calculation.ResumeLayout(false);
            this.Calculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button vehicle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox pckge;
        private System.Windows.Forms.DateTimePicker rtrndt;
        private System.Windows.Forms.DateTimePicker rntdt;
        private System.Windows.Forms.ComboBox lbl_vhcl;
        private System.Windows.Forms.Label vhcl_no;
        private System.Windows.Forms.Label package;
        private System.Windows.Forms.Label rnt_dt;
        private System.Windows.Forms.Label rtn_dt;
        private System.Windows.Forms.CheckBox wthdrvr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Addrss;
        private System.Windows.Forms.Label nic;
        private System.Windows.Forms.Label Cus_name;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox cus_tp;
        private System.Windows.Forms.TextBox cus_add;
        private System.Windows.Forms.TextBox cus_nic;
        private System.Windows.Forms.TextBox cusnm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endkm;
        private System.Windows.Forms.TextBox strtkm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mxkm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceKM;
        private System.Windows.Forms.GroupBox Calculation;
        private System.Windows.Forms.TextBox extrachrge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox waitingchrge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totchrge;
        private System.Windows.Forms.Label label6;
    }
}