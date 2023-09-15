using HealthCarePlus.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePlus
{
    internal class InterfaceManager
    {
        private static Login login = null;
        private static AdminDashboard adminDashboard = null;
        private static DoctorChannels doctorChannels = null;
        private static DoctorRegistration doctorRegistration = null;
        private static Invoice invoice = null;
        private static MedicationManagement medicationManagement = null;
        private static PatientAppoinments patientAppoinments = null;
        private static PatientManagement patientManagement = null;
        private static PatientRegistration patientRegistration = null;
        private static ReportsManagment reportsManagment = null;
        private static ResourcesManagment resourcesManagment = null;
        private static RoomsAndTheaters roomAndTheaters = null;
        private static StaffMemberRegistration staffMemberRegistration = null;
        private static StaffMemberAuthorization staffMemberAuthorization = null;

        public static void setLogin(Login freshInst)
        {
            login = freshInst;
        }

        public static void showLogin()
        {
            if (login == null || login.IsDisposed)
            {
                login = new Login();
                adminDashboard.Dispose();
            }
            else
            {
                adminDashboard.Dispose();
            }

            hideAll();
            login.Show();
        }

        public static void showAdminDashboard()
        {
            if (adminDashboard == null || adminDashboard.IsDisposed)
            {
                adminDashboard = new AdminDashboard();
            }
            hideAll();
            disposeOtherWindows();
            adminDashboard.Show();
        }

        public static void showStaffMemberRegistration()
        {
            if (staffMemberRegistration == null || staffMemberRegistration.IsDisposed)
            {
                staffMemberRegistration = new StaffMemberRegistration();
            }
            hideAll();
            staffMemberRegistration.Show();
        }

        public static void showDoctorChannels()
        {
            if (doctorChannels == null || doctorChannels.IsDisposed)
            {
                doctorChannels = new DoctorChannels();
            }
            hideAll();
            doctorChannels.Show();
        }

        public static void showDoctorRegistration()
        {
            if (doctorRegistration == null || doctorRegistration.IsDisposed)
            {
                doctorRegistration = new DoctorRegistration();
            }
            hideAll();
            doctorRegistration.Show();
        }

        public static void showInvoice()
        {
            if(invoice == null || invoice.IsDisposed)
            { 
                invoice = new Invoice();
            }
            hideAll();
            invoice.Show();
        }

        public static void showMedicalManagement()
        {
            if(medicationManagement == null || medicationManagement.IsDisposed)
            {
                medicationManagement = new MedicationManagement();
            }
            hideAll(); 
            medicationManagement.Show();
        }

        public static void showPatientAppointments()
        {
            if(patientAppoinments == null || patientAppoinments.IsDisposed)
            {
                patientAppoinments = new PatientAppoinments();
            }
            hideAll();
            patientAppoinments.Show();
        }

        public static void showPatientManagement()
        {
            if(patientManagement == null || patientManagement.IsDisposed)
            {
                patientManagement = new PatientManagement();
            }
            hideAll(); 
            patientManagement.Show();
        }

        public static void showPatientRegistration()
        {
            if(patientRegistration == null || patientRegistration.IsDisposed)
            {
                patientRegistration = new PatientRegistration();
            }
            hideAll(); 
            patientRegistration.Show();
        }

        public static void showReportsManagement()
        {
            if(reportsManagment == null || reportsManagment.IsDisposed)
            {
                reportsManagment = new ReportsManagment();
            }
            hideAll();
            reportsManagment.Show();
        }

        public static void showResourcesManager()
        {
            if(resourcesManagment == null || resourcesManagment.IsDisposed)
            {
                resourcesManagment = new ResourcesManagment();
            }
            hideAll();
            resourcesManagment.Show();
        }

        public static void showRoomAndTheaters()
        {
            if(roomAndTheaters == null || roomAndTheaters.IsDisposed)
            {
                roomAndTheaters = new RoomsAndTheaters();
            }
            hideAll();
            roomAndTheaters.Show();
        }

        public static void showStaffMemberAuthorization()
        {
            if (staffMemberAuthorization == null || staffMemberAuthorization.IsDisposed)
            {
                staffMemberAuthorization = new StaffMemberAuthorization();
            }
            hideAll(); 
            staffMemberAuthorization.Show();
        }

        private static void hideAll()
        {
            if (login != null) login.Hide();
            if (adminDashboard != null) adminDashboard.Hide();
            if (doctorChannels != null) doctorChannels.Hide();
            if (doctorRegistration != null) doctorRegistration.Hide();
            if (invoice != null) invoice.Hide();
            if (medicationManagement != null) medicationManagement.Hide();
            if (patientAppoinments != null) patientAppoinments.Hide();
            if (patientManagement != null) patientManagement.Hide();
            if (patientRegistration != null) patientRegistration.Hide();
            if (reportsManagment != null) reportsManagment.Hide();
            if (resourcesManagment != null) resourcesManagment.Hide();
            if (roomAndTheaters != null) roomAndTheaters.Hide();
            if (staffMemberRegistration != null) staffMemberRegistration.Hide();
            if(staffMemberAuthorization != null) staffMemberAuthorization.Hide();

        }

        private static void disposeOtherWindows()
        {
            if (doctorChannels != null) doctorChannels.Dispose();
            if (doctorRegistration != null) doctorRegistration.Dispose();
            if (invoice != null) invoice.Hide();
            if (medicationManagement != null) medicationManagement.Dispose();
            if (patientAppoinments != null) patientAppoinments.Dispose();
            if (patientManagement != null) patientManagement.Dispose();
            if (patientRegistration != null) patientRegistration.Dispose();
            if (reportsManagment != null) reportsManagment.Dispose();
            if (resourcesManagment != null) resourcesManagment.Dispose();
            if (roomAndTheaters != null) roomAndTheaters.Dispose();
            if (staffMemberRegistration != null) staffMemberRegistration.Dispose();
            if(staffMemberAuthorization != null) staffMemberAuthorization.Dispose();
        }

    }
}
