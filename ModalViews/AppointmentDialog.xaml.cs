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
using System.Windows.Shapes;

namespace Medic.ModalViews
{
    /// <summary>
    /// Логика взаимодействия для AppointmentDialog.xaml
    /// </summary>
    public partial class AppointmentDialog : Window
    {
        public int SelectedPatientId { get; set; }
        public int SelectedDoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }

        public AppointmentDialog(List<Patients> patients, List<Doctors> doctors, Appointments appointment = null)
        {
            InitializeComponent();

            PatientBox.ItemsSource = patients;
            DoctorBox.ItemsSource = doctors;

            if (appointment != null)
            {
                PatientBox.SelectedItem = patients.FirstOrDefault(p => p.Id == appointment.PatientId);
                DoctorBox.SelectedItem = doctors.FirstOrDefault(d => d.Id == appointment.DoctorId);
                DatePicker.SelectedDate = appointment.AppointmentDate;
                StatusBox.SelectedItem = StatusBox.Items.Cast<ComboBoxItem>().FirstOrDefault(i => i.Content.ToString() == appointment.Status);
            }
            else
            {
                DatePicker.SelectedDate = DateTime.Now;
                StatusBox.SelectedIndex = 0;
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            var patient = PatientBox.SelectedItem as Patients;
            var doctor = DoctorBox.SelectedItem as Doctors;

            if (patient == null || doctor == null || DatePicker.SelectedDate == null)
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            SelectedPatientId = patient.Id;
            SelectedDoctorId = doctor.Id;
            AppointmentDate = DatePicker.SelectedDate.Value;
            Status = (StatusBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
