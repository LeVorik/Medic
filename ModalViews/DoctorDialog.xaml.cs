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

namespace Medic
{
    /// <summary>
    /// Логика взаимодействия для DoctorDialog.xaml
    /// </summary>
    public partial class DoctorDialog : Window
    {
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string Room { get; set; }

        public DoctorDialog(string fullName = "", string specialty = "", string room = "")
        {
            InitializeComponent();

            FullNameBox.Text = fullName;
            SpecialtyBox.Text = specialty;
            RoomBox.Text = room;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullNameBox.Text))
            {
                MessageBox.Show("ФИО не может быть пустым.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            FullName = FullNameBox.Text;
            Specialty = SpecialtyBox.Text;
            Room = RoomBox.Text;
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
