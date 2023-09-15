namespace HealthCarePlus.Forms
{
    partial class ReportsManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsManagment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.brnClear = new System.Windows.Forms.Button();
            this.btnReportGen = new System.Windows.Forms.Button();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcelExport);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.brnClear);
            this.groupBox1.Controls.Add(this.btnReportGen);
            this.groupBox1.Controls.Add(this.dtToDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFromDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbReports);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(986, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports Manager";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(4, 94);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(977, 410);
            this.dataGridView.TabIndex = 8;
            // 
            // brnClear
            // 
            this.brnClear.Location = new System.Drawing.Point(665, 58);
            this.brnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(206, 22);
            this.brnClear.TabIndex = 7;
            this.brnClear.Text = "Clear";
            this.brnClear.UseVisualStyleBackColor = true;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // btnReportGen
            // 
            this.btnReportGen.Location = new System.Drawing.Point(665, 31);
            this.btnReportGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReportGen.Name = "btnReportGen";
            this.btnReportGen.Size = new System.Drawing.Size(206, 22);
            this.btnReportGen.TabIndex = 6;
            this.btnReportGen.Text = "Generate Report";
            this.btnReportGen.UseVisualStyleBackColor = true;
            this.btnReportGen.Click += new System.EventHandler(this.btnReportGen_Click);
            // 
            // dtToDate
            // 
            this.dtToDate.CustomFormat = "yyyy-MM-dd";
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDate.Location = new System.Drawing.Point(423, 58);
            this.dtToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(208, 23);
            this.dtToDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "To Date";
            // 
            // dtFromDate
            // 
            this.dtFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromDate.Location = new System.Drawing.Point(423, 31);
            this.dtFromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(208, 23);
            this.dtFromDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Date";
            // 
            // cmbReports
            // 
            this.cmbReports.FormattingEnabled = true;
            this.cmbReports.Location = new System.Drawing.Point(123, 58);
            this.cmbReports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbReports.Name = "cmbReports";
            this.cmbReports.Size = new System.Drawing.Size(216, 24);
            this.cmbReports.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Report";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(963, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(930, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(27, 27);
            this.btnHome.TabIndex = 32;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(876, 31);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(105, 49);
            this.btnExcelExport.TabIndex = 9;
            this.btnExcelExport.Text = "Export Excel";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // ReportsManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1002, 551);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportsManagment";
            this.Text = "Reports Managment";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReportsManagment_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.Button btnReportGen;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHome;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnExcelExport;
    }
}