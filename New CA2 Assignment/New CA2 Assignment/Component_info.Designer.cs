namespace New_CA2_Assignment
{
    partial class Component_info
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
            this.Btn_detail = new System.Windows.Forms.Button();
            this.dataGridcomponent = new System.Windows.Forms.DataGridView();
            this.Btn_logout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCost = new System.Windows.Forms.TextBox();
            this.textReplce_date = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textcomponent_num = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcomponent)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.BackgroundImage = global::New_CA2_Assignment.Properties.Resources.componenet;
            this.tabPage1.Controls.Add(this.Btn_detail);
            this.tabPage1.Controls.Add(this.dataGridcomponent);
            this.tabPage1.Controls.Add(this.Btn_logout);
            this.tabPage1.Controls.Add(this.btnDashboard);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(784, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Show Details";
            // 
            // Btn_detail
            // 
            this.Btn_detail.Location = new System.Drawing.Point(7, 65);
            this.Btn_detail.Name = "Btn_detail";
            this.Btn_detail.Size = new System.Drawing.Size(75, 23);
            this.Btn_detail.TabIndex = 4;
            this.Btn_detail.Text = "Show Details";
            this.Btn_detail.UseVisualStyleBackColor = true;
            this.Btn_detail.Click += new System.EventHandler(this.Btn_detail_Click);
            // 
            // dataGridcomponent
            // 
            this.dataGridcomponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcomponent.Location = new System.Drawing.Point(7, 141);
            this.dataGridcomponent.Name = "dataGridcomponent";
            this.dataGridcomponent.Size = new System.Drawing.Size(771, 165);
            this.dataGridcomponent.TabIndex = 3;
            // 
            // Btn_logout
            // 
            this.Btn_logout.Location = new System.Drawing.Point(7, 36);
            this.Btn_logout.Name = "Btn_logout";
            this.Btn_logout.Size = new System.Drawing.Size(75, 23);
            this.Btn_logout.TabIndex = 2;
            this.Btn_logout.Text = "Logout";
            this.Btn_logout.UseVisualStyleBackColor = true;
            this.Btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(7, 7);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.BackgroundImage = global::New_CA2_Assignment.Properties.Resources.componenet;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textCost);
            this.tabPage2.Controls.Add(this.textReplce_date);
            this.tabPage2.Controls.Add(this.textName);
            this.tabPage2.Controls.Add(this.textcomponent_num);
            this.tabPage2.Controls.Add(this.textId);
            this.tabPage2.Controls.Add(this.btnrefresh);
            this.tabPage2.Controls.Add(this.btndelete);
            this.tabPage2.Controls.Add(this.btnsave);
            this.tabPage2.Controls.Add(this.btnadd);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(784, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add component Number";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Replacement Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Component Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(174, 110);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(190, 20);
            this.textCost.TabIndex = 9;
            // 
            // textReplce_date
            // 
            this.textReplce_date.Location = new System.Drawing.Point(174, 84);
            this.textReplce_date.Name = "textReplce_date";
            this.textReplce_date.Size = new System.Drawing.Size(190, 20);
            this.textReplce_date.TabIndex = 8;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(175, 58);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(190, 20);
            this.textName.TabIndex = 7;
            // 
            // textcomponent_num
            // 
            this.textcomponent_num.Location = new System.Drawing.Point(175, 32);
            this.textcomponent_num.Name = "textcomponent_num";
            this.textcomponent_num.Size = new System.Drawing.Size(190, 20);
            this.textcomponent_num.TabIndex = 6;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(175, 6);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(190, 20);
            this.textId.TabIndex = 5;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(450, 53);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "View";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(558, 53);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(558, 6);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(450, 6);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Update";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 156);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(772, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick);
            // 
            // Component_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 363);
            this.Controls.Add(this.tabControl1);
            this.Name = "Component_info";
            this.Text = "Component_info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcomponent)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridcomponent;
        private System.Windows.Forms.Button Btn_logout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.TextBox textReplce_date;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textcomponent_num;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_detail;
    }
}