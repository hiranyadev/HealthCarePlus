using HealthCarePlus.Database;
using HealthCarePlus.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace HealthCarePlus.Forms
{
    public partial class ReportsManagment : Form
    {
        string curruntdate = DateTime.Now.ToString("yyyy-MM-dd");
        public ReportsManagment()
        {
            InitializeComponent();

            cmbReports.Items.Clear();
            cmbReports.Items.Add("Staff Member Report");
            cmbReports.Items.Add("Doctors Report");
            cmbReports.Items.Add("Patient Report");
            cmbReports.Items.Add("Channels Report");
            cmbReports.Items.Add("Income Report");

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

        private void btnReportGen_Click(object sender, EventArgs e)
        {
            DBConnection databaseConnection = new DBConnection();

            string from = dtFromDate.Text;
            string to = dtToDate.Text;

            string sql = "";

            if(cmbReports.Text.Equals("Staff Member Report"))
            {
                sql = "SELECT name, contact, nic, role, age FROM staff";
            }
            else if (cmbReports.Text.Equals("Doctors Report"))
            {
                sql = "SELECT fullname, contact, email, qualification, expertise, specialization FROM doctor";
            }
            else if (cmbReports.Text.Equals("Patient Report"))
            {
                sql = "SELECT patientName, contact, email, age, bloodgroup FROM patient";
            }
            else if (cmbReports.Text.Equals("Channels Report"))
            {
                sql = "";
            }
            else if (cmbReports.Text.Equals("Income Report"))
            {
                if(from == to)
                {
                    sql = "SELECT (SELECT ap.appoint_number FROM appointment ap WHERE ap.appointmentId = py.appointmentId) as Appointment_No, " +
                        "py.doctorCharges as Doctor_Charges, py.roomCharges as Room_Charges, py.thearterCharges as Thearter_Charges, py.hospitalCharges as Hospital_Charges, " +
                        "py.otherCharges as Other_Charges, py.totalAmount as Total_Amount FROM payments py WHERE py.printdate = '" + curruntdate + "'";
                }
                else
                {
                    sql = "SELECT (SELECT ap.appoint_number FROM appointment ap WHERE ap.appointmentId = py.appointmentId) as Appointment_No, " +
                        "py.doctorCharges as Doctor_Charges, py.roomCharges as Room_Charges, py.thearterCharges as Thearter_Charges, py.hospitalCharges as Hospital_Charges, " +
                        "py.otherCharges as Other_Charges, py.totalAmount as Total_Amount FROM payments py WHERE py.printdate >= '" + from + "' AND py.printdate <= '" + to + "'";
                }
                
            }

            try
            {
                dataGridView.DataSource = databaseConnection.searchDataByCritrea(sql);
            }
            catch (Exception ex)
            {
                dataGridView.DataSource = null;
                dataGridView.Refresh();
                MessageBox.Show("Cannot Generate the report!! Please Try Again !!");
            }
        }

        private void brnClear_Click(object sender, EventArgs e)
        {

        }

        private void ReportsManagment_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("C:\\Users\\hiranyay\\Desktop\\"+ cmbReports.Text + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
}
