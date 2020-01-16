using APBD5.DAL;
using APBD5.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace APBD5
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetDataFromDb();
            StudentsDataGrid.ItemsSource = Student._ListaStudentow;
            HowManyStudentsIsSelected.Content = $"Wybrano {StudentsDataGrid.SelectedItems.Count} studentów";
        }

        private void GetDataFromDb()
        {
            Studies._StudiesList = StudentDbService.PullStudiesFromDB();
            Subject._SubjectList = StudentDbService.PullSubjectsFromDB();
            Student._ListaStudentow = StudentDbService.PullStudentsFromDbToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var wnd = new DeansOffice();
            wnd.ShowDialog();
            ResetSubjects();
            if (wnd.NewStudent != null)
            {
                var newStudent = wnd.NewStudent;
                var isStudentAdded = StudentDbService.AddRecordToDb(newStudent);
                if (isStudentAdded)
                {
                    Student._ListaStudentow.Add(newStudent);
                    MessageBox.Show("Dodano studenta", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            //Check user decision
            if (StudentsDataGrid.SelectedItems.Count > 0)
            {
                var messageBoxResult = MessageBox.Show("Czy na pewno chcesz usunąć dane studentów?", "Deleting Students", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.OK)
                {
                    //Prepare list to remove
                    var listOfStudentsToRemove = StudentsDataGrid.SelectedItems;
                    var listOfIdToRemove = new List<int>();
                    foreach (Student s in listOfStudentsToRemove)
                    {
                        listOfIdToRemove.Add(s.Id);
                    }

                    //Remove from DB

                    var areStudentsRemoved = StudentDbService.RemoveFromDb(listOfIdToRemove);

                    //If succeeded, remove from DataGrid
                    if (areStudentsRemoved)
                    {
                        Student student;
                        for (int ii = Student._ListaStudentow.Count - 1; ii >= 0; ii--)
                        {
                            student = Student._ListaStudentow.ElementAt(ii);
                            if (listOfIdToRemove.Contains(student.Id))
                                Student._ListaStudentow.Remove(student);
                        }
                        if (listOfIdToRemove.Count == 1)
                            MessageBox.Show("Usunięto studenta", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Information);
                        else
                            MessageBox.Show("Usunięto studentów", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                }
            }
            else
                MessageBox.Show("Nie wybrano studentów", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void StudentsDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            HowManyStudentsIsSelected.Content = $"Wybrano {StudentsDataGrid.SelectedItems.Count} studentów";
        }

        private void DataGridRow_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var student = (Student)StudentsDataGrid.SelectedItem;
            var wnd = new DeansOffice(student);
            wnd.ShowDialog();
            if (wnd.NewStudent != null)
            {
                var editedStudent = wnd.NewStudent;
                var isStudentUpdated = StudentDbService.EditRecordInDb(student, editedStudent);
                if (isStudentUpdated)
                {
                    var orginalStudent = Student._ListaStudentow.First(s => s.Id == student.Id);
                    UpdateStudentDataInListaStudentow(orginalStudent, editedStudent);
                    MessageBox.Show("Uaktualniono dane studenta", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            ResetSubjects();
            //Student._ListaStudentow = StudentDbService.PullStudentsFromDbToList();
        }

        private void UpdateStudentDataInListaStudentow(Student orginalStudent, Student editedStudent)
        {
            orginalStudent.Imie = editedStudent.Imie;
            orginalStudent.Nazwisko = editedStudent.Nazwisko;
            orginalStudent.NrIndeksu = editedStudent.NrIndeksu;
            orginalStudent.Adres = editedStudent.Adres;
            orginalStudent.Studia = editedStudent.Studia;
            orginalStudent.ListaWybranychPrzedmiotow = editedStudent.ListaWybranychPrzedmiotow;
        }

        private void ResetSubjects()
        {
            foreach (Subject subject in Subject._SubjectList)
            {
                subject.IsChecked = false;
            }
        }
    }
}
