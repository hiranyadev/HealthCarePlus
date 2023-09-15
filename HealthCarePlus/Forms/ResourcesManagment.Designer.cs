namespace HealthCarePlus.Forms
{
    partial class ResourcesManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourcesManagment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbUpdateres = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnresoSubmit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtUserbility = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.cmbResCat = new System.Windows.Forms.ComboBox();
            this.btnresoClear = new System.Windows.Forms.Button();
            this.btnresoUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdresothers = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnlabtstClear = new System.Windows.Forms.Button();
            this.btnAddLabTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txttestCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResClear = new System.Windows.Forms.Button();
            this.btnResAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresOthers = new System.Windows.Forms.TextBox();
            this.txtResDescr = new System.Windows.Forms.TextBox();
            this.txtresCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1156, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resources Management";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbUpdateres);
            this.groupBox4.Controls.Add(this.dataGridView);
            this.groupBox4.Controls.Add(this.btnresoSubmit);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtCount);
            this.groupBox4.Controls.Add(this.txtUserbility);
            this.groupBox4.Controls.Add(this.txtBrand);
            this.groupBox4.Controls.Add(this.cmbResCat);
            this.groupBox4.Controls.Add(this.btnresoClear);
            this.groupBox4.Controls.Add(this.btnresoUpdate);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtAdresothers);
            this.groupBox4.Controls.Add(this.txtType);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(353, 43);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(798, 453);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Resource";
            // 
            // cmbUpdateres
            // 
            this.cmbUpdateres.FormattingEnabled = true;
            this.cmbUpdateres.Location = new System.Drawing.Point(19, 27);
            this.cmbUpdateres.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdateres.Name = "cmbUpdateres";
            this.cmbUpdateres.Size = new System.Drawing.Size(309, 24);
            this.cmbUpdateres.TabIndex = 35;
            this.cmbUpdateres.Text = "Select Resources Only For Update";
            this.cmbUpdateres.SelectedValueChanged += new System.EventHandler(this.cmbUpdateres_SelectedValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(346, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(447, 409);
            this.dataGridView.TabIndex = 34;
            // 
            // btnresoSubmit
            // 
            this.btnresoSubmit.Location = new System.Drawing.Point(152, 415);
            this.btnresoSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnresoSubmit.Name = "btnresoSubmit";
            this.btnresoSubmit.Size = new System.Drawing.Size(56, 22);
            this.btnresoSubmit.TabIndex = 15;
            this.btnresoSubmit.Text = "Submit";
            this.btnresoSubmit.UseVisualStyleBackColor = true;
            this.btnresoSubmit.Click += new System.EventHandler(this.btnresoSubmit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 142);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Usebility";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 172);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Count";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 202);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Others";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(130, 172);
            this.txtCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(198, 23);
            this.txtCount.TabIndex = 11;
            // 
            // txtUserbility
            // 
            this.txtUserbility.Location = new System.Drawing.Point(130, 142);
            this.txtUserbility.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserbility.Name = "txtUserbility";
            this.txtUserbility.Size = new System.Drawing.Size(198, 23);
            this.txtUserbility.TabIndex = 10;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(130, 115);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(198, 23);
            this.txtBrand.TabIndex = 9;
            // 
            // cmbResCat
            // 
            this.cmbResCat.FormattingEnabled = true;
            this.cmbResCat.Location = new System.Drawing.Point(130, 59);
            this.cmbResCat.Margin = new System.Windows.Forms.Padding(2);
            this.cmbResCat.Name = "cmbResCat";
            this.cmbResCat.Size = new System.Drawing.Size(198, 24);
            this.cmbResCat.TabIndex = 8;
            // 
            // btnresoClear
            // 
            this.btnresoClear.Location = new System.Drawing.Point(272, 415);
            this.btnresoClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnresoClear.Name = "btnresoClear";
            this.btnresoClear.Size = new System.Drawing.Size(56, 22);
            this.btnresoClear.TabIndex = 7;
            this.btnresoClear.Text = "Clear";
            this.btnresoClear.UseVisualStyleBackColor = true;
            this.btnresoClear.Click += new System.EventHandler(this.btnresoClear_Click_1);
            // 
            // btnresoUpdate
            // 
            this.btnresoUpdate.Location = new System.Drawing.Point(212, 415);
            this.btnresoUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnresoUpdate.Name = "btnresoUpdate";
            this.btnresoUpdate.Size = new System.Drawing.Size(56, 22);
            this.btnresoUpdate.TabIndex = 6;
            this.btnresoUpdate.Text = "Update";
            this.btnresoUpdate.UseVisualStyleBackColor = true;
            this.btnresoUpdate.Click += new System.EventHandler(this.btnresoUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Brand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Type";
            // 
            // txtAdresothers
            // 
            this.txtAdresothers.Location = new System.Drawing.Point(130, 202);
            this.txtAdresothers.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresothers.Multiline = true;
            this.txtAdresothers.Name = "txtAdresothers";
            this.txtAdresothers.Size = new System.Drawing.Size(198, 209);
            this.txtAdresothers.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(130, 86);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(198, 23);
            this.txtType.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Resource Category";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnlabtstClear);
            this.groupBox3.Controls.Add(this.btnAddLabTest);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtOthers);
            this.groupBox3.Controls.Add(this.txtDescr);
            this.groupBox3.Controls.Add(this.txttestCode);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 276);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(323, 219);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Lab Test";
            // 
            // btnlabtstClear
            // 
            this.btnlabtstClear.Location = new System.Drawing.Point(246, 182);
            this.btnlabtstClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnlabtstClear.Name = "btnlabtstClear";
            this.btnlabtstClear.Size = new System.Drawing.Size(56, 22);
            this.btnlabtstClear.TabIndex = 7;
            this.btnlabtstClear.Text = "Clear";
            this.btnlabtstClear.UseVisualStyleBackColor = true;
            this.btnlabtstClear.Click += new System.EventHandler(this.btnlabtstClear_Click);
            // 
            // btnAddLabTest
            // 
            this.btnAddLabTest.Location = new System.Drawing.Point(182, 182);
            this.btnAddLabTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLabTest.Name = "btnAddLabTest";
            this.btnAddLabTest.Size = new System.Drawing.Size(56, 22);
            this.btnAddLabTest.TabIndex = 6;
            this.btnAddLabTest.Text = "Submit";
            this.btnAddLabTest.UseVisualStyleBackColor = true;
            this.btnAddLabTest.Click += new System.EventHandler(this.btnAddLabTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Others";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // txtOthers
            // 
            this.txtOthers.Location = new System.Drawing.Point(105, 82);
            this.txtOthers.Margin = new System.Windows.Forms.Padding(2);
            this.txtOthers.Multiline = true;
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(198, 96);
            this.txtOthers.TabIndex = 3;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(105, 55);
            this.txtDescr.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(198, 23);
            this.txtDescr.TabIndex = 2;
            // 
            // txttestCode
            // 
            this.txttestCode.Location = new System.Drawing.Point(105, 28);
            this.txttestCode.Margin = new System.Windows.Forms.Padding(2);
            this.txttestCode.Name = "txttestCode";
            this.txttestCode.Size = new System.Drawing.Size(198, 23);
            this.txttestCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Test Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResClear);
            this.groupBox2.Controls.Add(this.btnResAdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtresOthers);
            this.groupBox2.Controls.Add(this.txtResDescr);
            this.groupBox2.Controls.Add(this.txtresCode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(323, 219);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Resource Category";
            // 
            // btnResClear
            // 
            this.btnResClear.Location = new System.Drawing.Point(246, 182);
            this.btnResClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnResClear.Name = "btnResClear";
            this.btnResClear.Size = new System.Drawing.Size(56, 22);
            this.btnResClear.TabIndex = 7;
            this.btnResClear.Text = "Clear";
            this.btnResClear.UseVisualStyleBackColor = true;
            this.btnResClear.Click += new System.EventHandler(this.btnResClear_Click);
            // 
            // btnResAdd
            // 
            this.btnResAdd.Location = new System.Drawing.Point(182, 182);
            this.btnResAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnResAdd.Name = "btnResAdd";
            this.btnResAdd.Size = new System.Drawing.Size(56, 22);
            this.btnResAdd.TabIndex = 6;
            this.btnResAdd.Text = "Submit";
            this.btnResAdd.UseVisualStyleBackColor = true;
            this.btnResAdd.Click += new System.EventHandler(this.btnResAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Others";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // txtresOthers
            // 
            this.txtresOthers.Location = new System.Drawing.Point(105, 82);
            this.txtresOthers.Margin = new System.Windows.Forms.Padding(2);
            this.txtresOthers.Multiline = true;
            this.txtresOthers.Name = "txtresOthers";
            this.txtresOthers.Size = new System.Drawing.Size(198, 96);
            this.txtresOthers.TabIndex = 3;
            // 
            // txtResDescr
            // 
            this.txtResDescr.Location = new System.Drawing.Point(105, 55);
            this.txtResDescr.Margin = new System.Windows.Forms.Padding(2);
            this.txtResDescr.Name = "txtResDescr";
            this.txtResDescr.Size = new System.Drawing.Size(198, 23);
            this.txtResDescr.TabIndex = 2;
            // 
            // txtresCode
            // 
            this.txtresCode.Location = new System.Drawing.Point(105, 28);
            this.txtresCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtresCode.Name = "txtresCode";
            this.txtresCode.Size = new System.Drawing.Size(198, 23);
            this.txtresCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource Code";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1133, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1100, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(27, 27);
            this.btnHome.TabIndex = 32;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ResourcesManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1176, 546);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ResourcesManagment";
            this.Text = "ResourcesManagment";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourcesManagment_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnlabtstClear;
        private System.Windows.Forms.Button btnAddLabTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txttestCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnResClear;
        private System.Windows.Forms.Button btnResAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresOthers;
        private System.Windows.Forms.TextBox txtResDescr;
        private System.Windows.Forms.TextBox txtresCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtUserbility;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.ComboBox cmbResCat;
        private System.Windows.Forms.Button btnresoClear;
        private System.Windows.Forms.Button btnresoUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdresothers;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHome;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnresoSubmit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cmbUpdateres;
    }
}