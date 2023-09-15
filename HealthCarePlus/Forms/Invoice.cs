using HealthCarePlus.Helpers;
using HealthCarePlus.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HealthCarePlus.Forms
{
    public partial class Invoice : Form
    {
        DataTable dt = new DataTable();
        DataRow dr = null;

        Payments payments = new Payments();

        public Invoice()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            InterfaceManager.showAdminDashboard();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "HealthCare Plus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Invoice_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }

        private void tnnPrint_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            try
            {
                if(appointmentno != null && appointmentno != "")
                {
                    payments.savePayments(payments);
                    printInvoice();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }            
        }        

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                invoiceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void invoiceData()
        {
            string appointmentno = txtappointment.Text.Trim();
            int othercharAmount = 0;

            if(txtOtherCharges.Text.Trim()!="" && txtOtherCharges.Text.Trim()!=null)
                othercharAmount = int.Parse(txtOtherCharges.Text.Trim());

            payments = payments.getInvoiceDataByAppointmentId(appointmentno);
            payments.OtherCharges = othercharAmount;           

            payments.TotalAmount = payments.RoomCharges + payments.DoctorCharges + payments.ThearterCharges + payments.OtherCharges + payments.HospitalCharges;
            txtTotal.Text = "" + payments.TotalAmount;
            dt = new DataTable();
            dt.Columns.Add("No");
            dt.Columns.Add("Description");
            dt.Columns.Add("Amount");

            dr = dt.NewRow();
            dr["No"] = "01";
            dr["Description"] = "Doctor Charges";
            dr["Amount"] = payments.DoctorCharges;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["No"] = "02";
            dr["Description"] = "Room Charges";
            dr["Amount"] = payments.RoomCharges;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["No"] = "03";
            dr["Description"] = "Theater Charges";
            dr["Amount"] = payments.ThearterCharges;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["No"] = "04";
            dr["Description"] = "Hospital Charges";
            dr["Amount"] = payments.HospitalCharges;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["No"] = "05";
            dr["Description"] = "Other Charges";
            dr["Amount"] = payments.OtherCharges;
            dt.Rows.Add(dr);

            dataGridView.DataSource = dt;
            dataGridView.Columns[0].Width = 30;
            dataGridView.Columns[1].Width = 500;
            dataGridView.Columns[2].Width = 170;
            dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void txtOtherCharges_Leave(object sender, EventArgs e)
        {
            invoiceData();
        }

        private void printInvoice()
        {
            dr = dt.NewRow();
            dr["No"] = "";
            dr["Description"] = "TOTAL AMOUNT";
            dr["Amount"] = payments.TotalAmount;
            dt.Rows.Add(dr);

            dataGridView.DataSource = dt;
            dataGridView.Columns[0].Width = 30;
            dataGridView.Columns[1].Width = 500;
            dataGridView.Columns[2].Width = 170;
            dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            generatePDF();

            dataGridView.DataSource = null;
            txtappointment.Clear();
            txtOtherCharges.Clear();
            txtTotal.Clear();
            dt = new DataTable();
            dr = null;
            payments = new Payments();

        }

        private void generatePDF()
        {
            if (dataGridView.Rows.Count > 0)
            {
                string appointmentno = txtappointment.Text.Trim();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = appointmentno;
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            Paragraph paragraph = new Paragraph("HEALTH CARE PLUS");

                            PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if(cell.Value != null)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(paragraph);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Invoice Printed Successufully");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Invoice to To Export !!!", "Info");
            }
        }

    }
}
