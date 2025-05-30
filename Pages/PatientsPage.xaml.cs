﻿using Medic.ModalViews;
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
    /// Логика взаимодействия для PatientsPage.xaml
    /// </summary>
    public partial class PatientsPage : Page
    {
        public PatientsPage()
        {
            InitializeComponent();
            LoadPatients();
        }
        private void LoadPatients()
        {
            PatientsDataGrid.ItemsSource = gVars.entities.Patients.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new PatientDialog();
            if (dialog.ShowDialog() == true)
            {
                var patient = new Patients
                {
                    FullName = dialog.FullName,
                    BirthDate = dialog.BirthDate,
                    Gender = dialog.Gender,
                    Phone = dialog.Phone,
                    Address = dialog.Address,
                    PolicyNumber = dialog.PolicyNumber,
                    Snils = dialog.Snils
                };

                gVars.entities.Patients.Add(patient);
                gVars.entities.SaveChanges();
                LoadPatients();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (PatientsDataGrid.SelectedItem is Patients patient)
            {
                var dialog = new PatientDialog(patient);
                if (dialog.ShowDialog() == true)
                {
                    patient.FullName = dialog.FullName;
                    patient.BirthDate = dialog.BirthDate;
                    patient.Gender = dialog.Gender;
                    patient.Phone = dialog.Phone;
                    patient.Address = dialog.Address;
                    patient.PolicyNumber = dialog.PolicyNumber;
                    patient.Snils = dialog.Snils;

                    gVars.entities.SaveChanges();
                    LoadPatients();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Patients del_patient = PatientsDataGrid.SelectedItem as Patients;
            if (del_patient is Patients patient)
            {
                if (MessageBox.Show("Удалить пациента?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) return;

                if (gVars.entities.Appointments.Any(x => x.PatientId == del_patient.Id))
                {
                    MessageBox.Show("У пациента имеется запись в журнале", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                gVars.entities.Patients.Remove(patient);
                gVars.entities.SaveChanges();
                LoadPatients();
            }
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PatientsDataGrid.SelectedItem != null)
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
