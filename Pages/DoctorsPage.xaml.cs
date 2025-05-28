using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для DoctorsPage.xaml
    /// </summary>
    public partial class DoctorsPage : Page
    {
        public DoctorsPage()
        {
            InitializeComponent();
            LoadDoctors();
        }
        private void LoadDoctors()
        {
            DoctorsDataGrid.ItemsSource = gVars.entities.Doctors.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new DoctorDialog();
            if (dialog.ShowDialog() == true)
            {
                var doctor = new Doctors
                {
                    FullName = dialog.FullName,
                    Specialty = dialog.Specialty,
                    Room = dialog.Room
                };

                gVars.entities.Doctors.Add(doctor);
                gVars.entities.SaveChanges();
                LoadDoctors();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (DoctorsDataGrid.SelectedItem is Doctors doctor)
            {
                var dialog = new DoctorDialog(doctor.FullName, doctor.Specialty, doctor.Room);
                if (dialog.ShowDialog() == true)
                {
                    doctor.FullName = dialog.FullName;
                    doctor.Specialty = dialog.Specialty;
                    doctor.Room = dialog.Room;

                    gVars.entities.SaveChanges();
                    LoadDoctors();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Doctors del_doctor = DoctorsDataGrid.SelectedItem as Doctors;
            if (del_doctor is Doctors doctor)
            {
                if (MessageBox.Show("Удалить врача?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) return;

                if (gVars.entities.Appointments.Any(x => x.DoctorId == del_doctor.Id))
                {
                    MessageBox.Show("У врача имеется запись в журнале", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                gVars.entities.Doctors.Remove(doctor);
                gVars.entities.SaveChanges();
                LoadDoctors();
            }
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DoctorsDataGrid.SelectedItem != null)
            {
                btn_Edit.IsEnabled = true;
                btn_Delete.IsEnabled = true;
            }
            else
            {
                btn_Edit.IsEnabled = false;
                btn_Delete.IsEnabled = false;
            }
        }
    }
}
