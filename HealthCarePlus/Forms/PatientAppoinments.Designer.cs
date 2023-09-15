namespace HealthCarePlus.Forms
{
    partial class PatientAppoinments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAppoinments));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.btnClientSearch = new System.Windows.Forms.Button();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnicNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddclear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAppointNo = new System.Windows.Forms.TextBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtclient = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnViewAppoint = new System.Windows.Forms.Button();
            this.txtpatientnic = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbresChannel = new System.Windows.Forms.ComboBox();
            this.txtOldChannel = new System.Windows.Forms.TextBox();
            this.btnResAppoint = new System.Windows.Forms.Button();
            this.txtResDoctor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtenterAppointNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnresclear = new System.Windows.Forms.Button();
            this.btnReschedule = new System.Windows.Forms.Button();
            this.txtresAppopint = new System.Windows.Forms.TextBox();
            this.txtResSeatNo = new System.Windows.Forms.TextBox();
            this.txtresClient = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtChannelDate = new System.Windows.Forms.TextBox();
            this.btnCanAppoint = new System.Windows.Forms.Button();
            this.txtcanDoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCanAppointNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCanClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSeatNo = new System.Windows.Forms.TextBox();
            this.txtcanClient = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.cmbChannel);
            this.groupBox1.Controls.Add(this.btnClientSearch);
            this.groupBox1.Controls.Add(this.cmbDoctor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnicNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddclear);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtAppointNo);
            this.groupBox1.Controls.Add(this.txtSeat);
            this.groupBox1.Controls.Add(this.txtclient);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(402, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make Appointment";
            // 
            // cmbChannel
            // 
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Location = new System.Drawing.Point(157, 118);
            this.cmbChannel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(230, 26);
            this.cmbChannel.TabIndex = 36;
            this.cmbChannel.SelectedValueChanged += new System.EventHandler(this.cmbChannel_SelectedValueChanged);
            // 
            // btnClientSearch
            // 
            this.btnClientSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClientSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnClientSearch.Image")));
            this.btnClientSearch.Location = new System.Drawing.Point(322, 28);
            this.btnClientSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClientSearch.Name = "btnClientSearch";
            this.btnClientSearch.Size = new System.Drawing.Size(65, 24);
            this.btnClientSearch.TabIndex = 35;
            this.btnClientSearch.UseVisualStyleBackColor = false;
            this.btnClientSearch.Click += new System.EventHandler(this.btnClientSearch_Click);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(157, 89);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(230, 26);
            this.cmbDoctor.TabIndex = 29;
            this.cmbDoctor.SelectedValueChanged += new System.EventHandler(this.cmbDoctor_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Search Client By NIC";
            // 
            // txtnicNo
            // 
            this.txtnicNo.Location = new System.Drawing.Point(157, 27);
            this.txtnicNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnicNo.Name = "txtnicNo";
            this.txtnicNo.Size = new System.Drawing.Size(163, 25);
            this.txtnicNo.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Appointment Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Seat Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select Channel Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Select Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Client Name";
            // 
            // btnAddclear
            // 
            this.btnAddclear.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddclear.Location = new System.Drawing.Point(316, 206);
            this.btnAddclear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddclear.Name = "btnAddclear";
            this.btnAddclear.Size = new System.Drawing.Size(71, 27);
            this.btnAddclear.TabIndex = 10;
            this.btnAddclear.Text = "Clear";
            this.btnAddclear.UseVisualStyleBackColor = true;
            this.btnAddclear.Click += new System.EventHandler(this.btnAddclear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(242, 206);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(71, 27);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAppointNo
            // 
            this.txtAppointNo.Location = new System.Drawing.Point(157, 176);
            this.txtAppointNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAppointNo.Multiline = true;
            this.txtAppointNo.Name = "txtAppointNo";
            this.txtAppointNo.Size = new System.Drawing.Size(230, 27);
            this.txtAppointNo.TabIndex = 5;
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(157, 147);
            this.txtSeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(230, 25);
            this.txtSeat.TabIndex = 4;
            // 
            // txtclient
            // 
            this.txtclient.Location = new System.Drawing.Point(157, 62);
            this.txtclient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtclient.Name = "txtclient";
            this.txtclient.Size = new System.Drawing.Size(230, 25);
            this.txtclient.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Controls.Add(this.btnViewAppoint);
            this.groupBox2.Controls.Add(this.txtpatientnic);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(424, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(466, 289);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search By Patient NIC";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(10, 55);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(445, 220);
            this.dataGridView.TabIndex = 20;
            // 
            // btnViewAppoint
            // 
            this.btnViewAppoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewAppoint.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAppoint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewAppoint.Image = ((System.Drawing.Image)(resources.GetObject("btnViewAppoint.Image")));
            this.btnViewAppoint.Location = new System.Drawing.Point(390, 23);
            this.btnViewAppoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewAppoint.Name = "btnViewAppoint";
            this.btnViewAppoint.Size = new System.Drawing.Size(65, 24);
            this.btnViewAppoint.TabIndex = 34;
            this.btnViewAppoint.UseVisualStyleBackColor = false;
            this.btnViewAppoint.Click += new System.EventHandler(this.btnViewAppoint_Click);
            // 
            // txtpatientnic
            // 
            this.txtpatientnic.Location = new System.Drawing.Point(140, 23);
            this.txtpatientnic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpatientnic.Name = "txtpatientnic";
            this.txtpatientnic.Size = new System.Drawing.Size(248, 25);
            this.txtpatientnic.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cmbresChannel);
            this.groupBox3.Controls.Add(this.txtOldChannel);
            this.groupBox3.Controls.Add(this.btnResAppoint);
            this.groupBox3.Controls.Add(this.txtResDoctor);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtenterAppointNo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnresclear);
            this.groupBox3.Controls.Add(this.btnReschedule);
            this.groupBox3.Controls.Add(this.txtresAppopint);
            this.groupBox3.Controls.Add(this.txtResSeatNo);
            this.groupBox3.Controls.Add(this.txtresClient);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 268);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(402, 285);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reschedule Appointment";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 157);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 16);
            this.label20.TabIndex = 38;
            this.label20.Text = "Select New Channel Date";
            // 
            // cmbresChannel
            // 
            this.cmbresChannel.FormattingEnabled = true;
            this.cmbresChannel.Location = new System.Drawing.Point(157, 153);
            this.cmbresChannel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbresChannel.Name = "cmbresChannel";
            this.cmbresChannel.Size = new System.Drawing.Size(230, 26);
            this.cmbresChannel.TabIndex = 37;
            this.cmbresChannel.SelectedValueChanged += new System.EventHandler(this.cmbresChannel_SelectedValueChanged);
            // 
            // txtOldChannel
            // 
            this.txtOldChannel.Location = new System.Drawing.Point(157, 121);
            this.txtOldChannel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOldChannel.Name = "txtOldChannel";
            this.txtOldChannel.Size = new System.Drawing.Size(230, 25);
            this.txtOldChannel.TabIndex = 36;
            // 
            // btnResAppoint
            // 
            this.btnResAppoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResAppoint.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResAppoint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResAppoint.Image = ((System.Drawing.Image)(resources.GetObject("btnResAppoint.Image")));
            this.btnResAppoint.Location = new System.Drawing.Point(324, 28);
            this.btnResAppoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResAppoint.Name = "btnResAppoint";
            this.btnResAppoint.Size = new System.Drawing.Size(65, 24);
            this.btnResAppoint.TabIndex = 35;
            this.btnResAppoint.UseVisualStyleBackColor = false;
            this.btnResAppoint.Click += new System.EventHandler(this.btnResAppoint_Click);
            // 
            // txtResDoctor
            // 
            this.txtResDoctor.Location = new System.Drawing.Point(157, 91);
            this.txtResDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResDoctor.Name = "txtResDoctor";
            this.txtResDoctor.Size = new System.Drawing.Size(230, 25);
            this.txtResDoctor.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Enter Appointment No";
            // 
            // txtenterAppointNo
            // 
            this.txtenterAppointNo.Location = new System.Drawing.Point(157, 27);
            this.txtenterAppointNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtenterAppointNo.Name = "txtenterAppointNo";
            this.txtenterAppointNo.Size = new System.Drawing.Size(163, 25);
            this.txtenterAppointNo.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Appointment Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Seat Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Select Old Channel Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Select Doctor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Client Name";
            // 
            // btnresclear
            // 
            this.btnresclear.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresclear.Location = new System.Drawing.Point(316, 249);
            this.btnresclear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnresclear.Name = "btnresclear";
            this.btnresclear.Size = new System.Drawing.Size(71, 27);
            this.btnresclear.TabIndex = 10;
            this.btnresclear.Text = "Clear";
            this.btnresclear.UseVisualStyleBackColor = true;
            this.btnresclear.Click += new System.EventHandler(this.btnresclear_Click);
            // 
            // btnReschedule
            // 
            this.btnReschedule.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReschedule.Location = new System.Drawing.Point(229, 249);
            this.btnReschedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReschedule.Name = "btnReschedule";
            this.btnReschedule.Size = new System.Drawing.Size(84, 27);
            this.btnReschedule.TabIndex = 9;
            this.btnReschedule.Text = "Reschedule";
            this.btnReschedule.UseVisualStyleBackColor = true;
            this.btnReschedule.Click += new System.EventHandler(this.btnReschedule_Click);
            // 
            // txtresAppopint
            // 
            this.txtresAppopint.Location = new System.Drawing.Point(157, 215);
            this.txtresAppopint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtresAppopint.Multiline = true;
            this.txtresAppopint.Name = "txtresAppopint";
            this.txtresAppopint.Size = new System.Drawing.Size(230, 27);
            this.txtresAppopint.TabIndex = 5;
            // 
            // txtResSeatNo
            // 
            this.txtResSeatNo.Location = new System.Drawing.Point(157, 186);
            this.txtResSeatNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResSeatNo.Name = "txtResSeatNo";
            this.txtResSeatNo.Size = new System.Drawing.Size(230, 25);
            this.txtResSeatNo.TabIndex = 4;
            // 
            // txtresClient
            // 
            this.txtresClient.Location = new System.Drawing.Point(157, 62);
            this.txtresClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtresClient.Name = "txtresClient";
            this.txtresClient.Size = new System.Drawing.Size(230, 25);
            this.txtresClient.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.txtChannelDate);
            this.groupBox4.Controls.Add(this.btnCanAppoint);
            this.groupBox4.Controls.Add(this.txtcanDoc);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtCanAppointNo);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.btnCanClear);
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.txtSeatNo);
            this.groupBox4.Controls.Add(this.txtcanClient);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(424, 335);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(466, 216);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cancel Appointment";
            // 
            // txtChannelDate
            // 
            this.txtChannelDate.Location = new System.Drawing.Point(157, 120);
            this.txtChannelDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChannelDate.Name = "txtChannelDate";
            this.txtChannelDate.Size = new System.Drawing.Size(298, 25);
            this.txtChannelDate.TabIndex = 36;
            // 
            // btnCanAppoint
            // 
            this.btnCanAppoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCanAppoint.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanAppoint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCanAppoint.Image = ((System.Drawing.Image)(resources.GetObject("btnCanAppoint.Image")));
            this.btnCanAppoint.Location = new System.Drawing.Point(390, 28);
            this.btnCanAppoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCanAppoint.Name = "btnCanAppoint";
            this.btnCanAppoint.Size = new System.Drawing.Size(65, 24);
            this.btnCanAppoint.TabIndex = 35;
            this.btnCanAppoint.UseVisualStyleBackColor = false;
            this.btnCanAppoint.Click += new System.EventHandler(this.btnCanAppoint_Click);
            // 
            // txtcanDoc
            // 
            this.txtcanDoc.Location = new System.Drawing.Point(157, 91);
            this.txtcanDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcanDoc.Name = "txtcanDoc";
            this.txtcanDoc.Size = new System.Drawing.Size(298, 25);
            this.txtcanDoc.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 33);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Enter Appointment No";
            // 
            // txtCanAppointNo
            // 
            this.txtCanAppointNo.Location = new System.Drawing.Point(157, 27);
            this.txtCanAppointNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCanAppointNo.Name = "txtCanAppointNo";
            this.txtCanAppointNo.Size = new System.Drawing.Size(229, 25);
            this.txtCanAppointNo.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 153);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Seat Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 124);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 16);
            this.label17.TabIndex = 19;
            this.label17.Text = "Channel Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 96);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Doctor";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(4, 67);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 16);
            this.label19.TabIndex = 17;
            this.label19.Text = "Client Name";
            // 
            // btnCanClear
            // 
            this.btnCanClear.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanClear.Location = new System.Drawing.Point(384, 179);
            this.btnCanClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCanClear.Name = "btnCanClear";
            this.btnCanClear.Size = new System.Drawing.Size(71, 27);
            this.btnCanClear.TabIndex = 10;
            this.btnCanClear.Text = "Clear";
            this.btnCanClear.UseVisualStyleBackColor = true;
            this.btnCanClear.Click += new System.EventHandler(this.btnCanClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(310, 179);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 27);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSeatNo
            // 
            this.txtSeatNo.Location = new System.Drawing.Point(157, 147);
            this.txtSeatNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeatNo.Name = "txtSeatNo";
            this.txtSeatNo.Size = new System.Drawing.Size(298, 25);
            this.txtSeatNo.TabIndex = 4;
            // 
            // txtcanClient
            // 
            this.txtcanClient.Location = new System.Drawing.Point(157, 62);
            this.txtcanClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcanClient.Name = "txtcanClient";
            this.txtcanClient.Size = new System.Drawing.Size(298, 25);
            this.txtcanClient.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(866, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(833, 10);
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
            // PatientAppoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(901, 564);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PatientAppoinments";
            this.Text = "Manage Appoinments";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PatientAppoinments_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnicNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddclear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAppointNo;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.TextBox txtclient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtpatientnic;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtResDoctor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtenterAppointNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnresclear;
        private System.Windows.Forms.Button btnReschedule;
        private System.Windows.Forms.TextBox txtresAppopint;
        private System.Windows.Forms.TextBox txtResSeatNo;
        private System.Windows.Forms.TextBox txtresClient;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtcanDoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCanAppointNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCanClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSeatNo;
        private System.Windows.Forms.TextBox txtcanClient;
        private System.Windows.Forms.Button btnViewAppoint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHome;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnClientSearch;
        private System.Windows.Forms.Button btnCanAppoint;
        private System.Windows.Forms.Button btnResAppoint;
        private System.Windows.Forms.ComboBox cmbChannel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbresChannel;
        private System.Windows.Forms.TextBox txtOldChannel;
        private System.Windows.Forms.TextBox txtChannelDate;
    }
}