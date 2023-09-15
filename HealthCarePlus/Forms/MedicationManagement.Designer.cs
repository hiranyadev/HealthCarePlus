namespace HealthCarePlus.Forms
{
    partial class MedicationManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicationManagement));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtappointment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtappointno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbloodgrp = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1285, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 33);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1241, 15);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(36, 33);
            this.btnHome.TabIndex = 32;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(894, 18);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(87, 30);
            this.btnsearch.TabIndex = 34;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtappointment
            // 
            this.txtappointment.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtappointment.Location = new System.Drawing.Point(476, 19);
            this.txtappointment.Name = "txtappointment";
            this.txtappointment.Size = new System.Drawing.Size(412, 29);
            this.txtappointment.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Appointment Number";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 286);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1304, 243);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Patient Medical Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(440, 62);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(881, 199);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lab Results";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtappointno);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtbloodgrp);
            this.groupBox2.Controls.Add(this.txtage);
            this.groupBox2.Controls.Add(this.txtpatientname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(408, 199);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Personal Details";
            // 
            // txtappointno
            // 
            this.txtappointno.Location = new System.Drawing.Point(128, 144);
            this.txtappointno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtappointno.Name = "txtappointno";
            this.txtappointno.Size = new System.Drawing.Size(265, 27);
            this.txtappointno.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Appointment";
            // 
            // txtbloodgrp
            // 
            this.txtbloodgrp.Location = new System.Drawing.Point(128, 102);
            this.txtbloodgrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbloodgrp.Name = "txtbloodgrp";
            this.txtbloodgrp.Size = new System.Drawing.Size(265, 27);
            this.txtbloodgrp.TabIndex = 5;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(128, 66);
            this.txtage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(265, 27);
            this.txtage.TabIndex = 4;
            // 
            // txtpatientname
            // 
            this.txtpatientname.Location = new System.Drawing.Point(128, 30);
            this.txtpatientname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(265, 27);
            this.txtpatientname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Blood Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patient Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 166);
            this.dataGridView1.TabIndex = 49;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1292, 213);
            this.dataGridView2.TabIndex = 50;
            // 
            // MedicationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1337, 556);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtappointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MedicationManagement";
            this.Text = "MedicationManagement";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MedicationManagement_MouseDown);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnsearch;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txtappointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtappointno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbloodgrp;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}