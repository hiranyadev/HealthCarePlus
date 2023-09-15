namespace HealthCarePlus.Forms
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtappointment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOtherCharges = new System.Windows.Forms.TextBox();
            this.tnnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(761, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(728, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(27, 27);
            this.btnHome.TabIndex = 32;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerateInvoice.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInvoice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerateInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateInvoice.Image")));
            this.btnGenerateInvoice.Location = new System.Drawing.Point(534, 20);
            this.btnGenerateInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(65, 24);
            this.btnGenerateInvoice.TabIndex = 34;
            this.btnGenerateInvoice.UseVisualStyleBackColor = false;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtappointment
            // 
            this.txtappointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtappointment.Location = new System.Drawing.Point(285, 22);
            this.txtappointment.Margin = new System.Windows.Forms.Padding(2);
            this.txtappointment.Name = "txtappointment";
            this.txtappointment.Size = new System.Drawing.Size(246, 21);
            this.txtappointment.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 14);
            this.label1.TabIndex = 36;
            this.label1.Text = "Appointment Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 371);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 14);
            this.label3.TabIndex = 40;
            this.label3.Text = "TOTAL BILL AMOUNT";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(511, 366);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(270, 35);
            this.txtTotal.TabIndex = 39;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 64);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(758, 249);
            this.dataGridView.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 43;
            this.label2.Text = "Other Charges";
            // 
            // txtOtherCharges
            // 
            this.txtOtherCharges.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherCharges.Location = new System.Drawing.Point(511, 332);
            this.txtOtherCharges.Name = "txtOtherCharges";
            this.txtOtherCharges.Size = new System.Drawing.Size(270, 23);
            this.txtOtherCharges.TabIndex = 44;
            this.txtOtherCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtherCharges.Leave += new System.EventHandler(this.txtOtherCharges_Leave);
            // 
            // tnnPrint
            // 
            this.tnnPrint.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnnPrint.Location = new System.Drawing.Point(604, 21);
            this.tnnPrint.Name = "tnnPrint";
            this.tnnPrint.Size = new System.Drawing.Size(75, 23);
            this.tnnPrint.TabIndex = 45;
            this.tnnPrint.Text = "Print";
            this.tnnPrint.UseVisualStyleBackColor = true;
            this.tnnPrint.Click += new System.EventHandler(this.tnnPrint_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.tnnPrint);
            this.Controls.Add(this.txtOtherCharges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtappointment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnGenerateInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Invoice_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtappointment;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtOtherCharges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tnnPrint;
    }
}