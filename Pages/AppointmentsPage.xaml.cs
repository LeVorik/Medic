using Medic.ModalViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Medic.Pages
{
    /// <summary>
    /// Логика взаимодействия для AppointmentsPage.xaml
    /// </summary>
    public partial class AppointmentsPage : Page
    {
        public AppointmentsPage()
        {
            InitializeComponent();
            LoadAppointments();
        }
        private void LoadAppointments()
        {
            AppointmentsDataGrid.ItemsSource = gVars.entities.Appointments
                .Include("Patients")
                .Include("Doctors")
                .ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AppointmentDialog(gVars.entities.Patients.ToList(), gVars.entities.Doctors.ToList());
            if (dialog.ShowDialog() == true)
            {
                var appointment = new Appointments
                {
                    PatientId = dialog.SelectedPatientId,
                    DoctorId = dialog.SelectedDoctorId,
                    AppointmentDate = dialog.AppointmentDate,
                    Status = dialog.Status
                };

                gVars.entities.Appointments.Add(appointment);
                gVars.entities.SaveChanges();
                LoadAppointments();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (AppointmentsDataGrid.SelectedItem is Appointments appointment)
            {
                var dialog = new AppointmentDialog(gVars.entities.Patients.ToList(), gVars.entities.Doctors.ToList(), appointment);
                if (dialog.ShowDialog() == true)
                {
                    appointment.PatientId = dialog.SelectedPatientId;
                    appointment.DoctorId = dialog.SelectedDoctorId;
                    appointment.AppointmentDate = dialog.AppointmentDate;
                    appointment.Status = dialog.Status;

                    gVars.entities.SaveChanges();
                    LoadAppointments();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (AppointmentsDataGrid.SelectedItem is Appointments appointment)
            {
                if (MessageBox.Show("Удалить запись?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    gVars.entities.Appointments.Remove(appointment);
                    gVars.entities.SaveChanges();
                    LoadAppointments();
                }
            }
        }
    }
}
