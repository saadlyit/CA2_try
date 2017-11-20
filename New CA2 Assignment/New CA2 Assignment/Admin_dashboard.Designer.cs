namespace New_CA2_Assignment
{
    partial class Admin_dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.combobox_accesslevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnn_deletee = new System.Windows.Forms.Button();
            this.Btnn_vieww = new System.Windows.Forms.Button();
            this.Btnn_savee = new System.Windows.Forms.Button();
            this.btnn_update = new System.Windows.Forms.Button();
            this.dataGridViiew_userdetails = new System.Windows.Forms.DataGridView();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textusename = new System.Windows.Forms.TextBox();
            this.textsurname = new System.Windows.Forms.TextBox();
            this.textforname = new System.Windows.Forms.TextBox();
            this.textuserid = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViiew_userdetails)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.BackgroundImage = global::New_CA2_Assignment.Properties.Resources.login;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.combobox_accesslevel);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Btnn_deletee);
            this.tabPage1.Controls.Add(this.Btnn_vieww);
            this.tabPage1.Controls.Add(this.Btnn_savee);
            this.tabPage1.Controls.Add(this.btnn_update);
            this.tabPage1.Controls.Add(this.dataGridViiew_userdetails);
            this.tabPage1.Controls.Add(this.textpassword);
            this.tabPage1.Controls.Add(this.textusename);
            this.tabPage1.Controls.Add(this.textsurname);
            this.tabPage1.Controls.Add(this.textforname);
            this.tabPage1.Controls.Add(this.textuserid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add User Details";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // combobox_accesslevel
            // 
            this.combobox_accesslevel.FormattingEnabled = true;
            this.combobox_accesslevel.Items.AddRange(new object[] {
            "1",
            "2"});
            this.combobox_accesslevel.Location = new System.Drawing.Point(185, 133);
            this.combobox_accesslevel.Name = "combobox_accesslevel";
            this.combobox_accesslevel.Size = new System.Drawing.Size(173, 21);
            this.combobox_accesslevel.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Access Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Forename";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "User id";
            // 
            // Btnn_deletee
            // 
            this.Btnn_deletee.Location = new System.Drawing.Point(509, 81);
            this.Btnn_deletee.Name = "Btnn_deletee";
            this.Btnn_deletee.Size = new System.Drawing.Size(75, 39);
            this.Btnn_deletee.TabIndex = 82;
            this.Btnn_deletee.Text = "Delete";
            this.Btnn_deletee.UseVisualStyleBackColor = true;
            this.Btnn_deletee.Click += new System.EventHandler(this.Btnn_deletee_Click);
            // 
            // Btnn_vieww
            // 
            this.Btnn_vieww.Location = new System.Drawing.Point(395, 81);
            this.Btnn_vieww.Name = "Btnn_vieww";
            this.Btnn_vieww.Size = new System.Drawing.Size(75, 39);
            this.Btnn_vieww.TabIndex = 81;
            this.Btnn_vieww.Text = "View";
            this.Btnn_vieww.UseVisualStyleBackColor = true;
            this.Btnn_vieww.Click += new System.EventHandler(this.Btnn_vieww_Click);
            // 
            // Btnn_savee
            // 
            this.Btnn_savee.Location = new System.Drawing.Point(509, 6);
            this.Btnn_savee.Name = "Btnn_savee";
            this.Btnn_savee.Size = new System.Drawing.Size(75, 39);
            this.Btnn_savee.TabIndex = 80;
            this.Btnn_savee.Text = "Save";
            this.Btnn_savee.UseVisualStyleBackColor = true;
            this.Btnn_savee.Click += new System.EventHandler(this.Btnn_savee_Click);
            // 
            // btnn_update
            // 
            this.btnn_update.Location = new System.Drawing.Point(395, 6);
            this.btnn_update.Name = "btnn_update";
            this.btnn_update.Size = new System.Drawing.Size(75, 39);
            this.btnn_update.TabIndex = 79;
            this.btnn_update.Text = "Update";
            this.btnn_update.UseVisualStyleBackColor = true;
            this.btnn_update.Click += new System.EventHandler(this.btnn_update_Click);
            // 
            // dataGridViiew_userdetails
            // 
            this.dataGridViiew_userdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViiew_userdetails.Location = new System.Drawing.Point(7, 178);
            this.dataGridViiew_userdetails.Name = "dataGridViiew_userdetails";
            this.dataGridViiew_userdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViiew_userdetails.Size = new System.Drawing.Size(757, 144);
            this.dataGridViiew_userdetails.TabIndex = 78;
            this.dataGridViiew_userdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViiew_userdetails_CellContentClick);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(185, 107);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(173, 20);
            this.textpassword.TabIndex = 77;
            // 
            // textusename
            // 
            this.textusename.Location = new System.Drawing.Point(185, 81);
            this.textusename.Name = "textusename";
            this.textusename.Size = new System.Drawing.Size(173, 20);
            this.textusename.TabIndex = 76;
            // 
            // textsurname
            // 
            this.textsurname.Location = new System.Drawing.Point(185, 55);
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(173, 20);
            this.textsurname.TabIndex = 75;
            // 
            // textforname
            // 
            this.textforname.Location = new System.Drawing.Point(185, 29);
            this.textforname.Name = "textforname";
            this.textforname.Size = new System.Drawing.Size(173, 20);
            this.textforname.TabIndex = 74;
            // 
            // textuserid
            // 
            this.textuserid.Location = new System.Drawing.Point(185, 3);
            this.textuserid.Name = "textuserid";
            this.textuserid.Size = new System.Drawing.Size(173, 20);
            this.textuserid.TabIndex = 73;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = global::New_CA2_Assignment.Properties.Resources.leo;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(770, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main Dahboard";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::New_CA2_Assignment.Properties.Resources.totalproductivemaintenance_150831151458_lva1_app6892_thumbnail_4;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(6, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 102);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::New_CA2_Assignment.Properties.Resources.componenet;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(319, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 102);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::New_CA2_Assignment.Properties.Resources.maintenance;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(623, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 102);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 366);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin_dashboard";
            this.Text = "Admin_dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViiew_userdetails)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Btnn_deletee;
        private System.Windows.Forms.Button Btnn_vieww;
        private System.Windows.Forms.Button Btnn_savee;
        private System.Windows.Forms.Button btnn_update;
        private System.Windows.Forms.DataGridView dataGridViiew_userdetails;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textusename;
        private System.Windows.Forms.TextBox textsurname;
        private System.Windows.Forms.TextBox textforname;
        private System.Windows.Forms.TextBox textuserid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_accesslevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}