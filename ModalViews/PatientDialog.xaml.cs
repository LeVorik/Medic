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
    /// Логика взаимодействия для PatientDialog.xaml
    /// </summary>
    public partial class PatientDialog : Window
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PolicyNumber { get; set; }
        public string Snils { get; set; }

        public PatientDialog(Patients patient = null)
        {
            InitializeComponent();

            if (patient != null)
            {
                FullNameBox.Text = patient.FullName;
                BirthDatePicker.SelectedDate = patient.BirthDate;
                if (patient.Gender == "М") MaleRadio.IsChecked = true;
                if (patient.Gender == "Ж") FemaleRadio.IsChecked = true;
                PhoneBox.Text = patient.Phone;
                AddressBox.Text = patient.Address;
                PolicyBox.Text = patient.PolicyNumber;
                SnilsBox.Text = patient.Snils;
            }
            else
            {
                BirthDatePicker.SelectedDate = DateTime.Now.AddYears(-18);
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullNameBox.Text) || BirthDatePicker.SelectedDate == null)
            {
                MessageBox.Show("ФИО и дата рождения обязательны.");
                return;
            }

            if (MaleRadio.IsChecked == false && FemaleRadio.IsChecked == false)
            {
                MessageBox.Show("Выберите пол.");
                return;
            }

            FullName = FullNameBox.Text;
            BirthDate = BirthDatePicker.SelectedDate.Value;
            Gender = MaleRadio.IsChecked == true ? "М" : "Ж";
            Phone = PhoneBox.Text;
            Address = AddressBox.Text;
            PolicyNumber = PolicyBox.Text;
            Snils = SnilsBox.Text;

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
