using APBD5.DAL;
using APBD5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace APBD5
{
    /// <summary>
    /// Interaction logic for DeansOffice.xaml
    /// </summary>
    public partial class DeansOffice : Window
    {
        public Student NewStudent { get; set; }
        public List StudentSubjects = new List();
        public DeansOffice()
        {
            InitializeComponent();
            TitleLabel.Content = "Dodaj studenta";
            ConfirmButton.Content = "Dodaj";

            StudiaComboBox.ItemsSource = Studies._StudiesList;
            PrzedmiotyListBox.ItemsSource = Subject._SubjectList;
        }
        public DeansOffice(Student student)
        {
            InitializeComponent();
            TitleLabel.Content = "Edytuj studenta";
            ConfirmButton.Content = "Ok";

            NazwiskoTextBox.Text = student.Nazwisko;
            ImieTextBox.Text = student.Imie;
            NrIndeksuTextBox.Text = student.NrIndeksu;

            StudiaComboBox.ItemsSource = Studies._StudiesList;
            StudiaComboBox.SelectedIndex = student.Studia.Id - 1;

            PrzedmiotyListBox.ItemsSource = Subject._SubjectList;
            foreach (Subject s in student.ListaWybranychPrzedmiotow)
            {
                s.IsChecked = true;
            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            var tmpNazwisko = NazwiskoTextBox.Text;
            var tmpImie = ImieTextBox.Text;
            var tmpNrIndeksu = NrIndeksuTextBox.Text;
            var StudentSubjects = Subject._SubjectList.Where(p => p.IsChecked == true);
            var IsSubjectsSelected = StudentSubjects.Any();

            if (tmpImie != "" && tmpNazwisko != "" && tmpNrIndeksu != "" && StudiaComboBox.SelectedItem != null && IsSubjectsSelected)
            {
                var match = Regex.Match(tmpNrIndeksu, "^s[0-9]{4,5}$");
                var tmpStudia = ((Studies)StudiaComboBox.SelectedItem);
                if (match.Success)
                {
                    NewStudent = new Student
                    {
                        Imie = tmpImie,
                        Nazwisko = tmpNazwisko,
                        NrIndeksu = tmpNrIndeksu,
                        Adres = "Ulica i miasto",
                        Studia = tmpStudia,
                        ListaWybranychPrzedmiotow = StudentSubjects.ToList()
                    };
                    Close();
                }
                else
                {
                    MessageBox.Show("Nr indeksu jest niepoprawny", "Zadanie3i4", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Co najmniej jedno pole jest puste", "Zadanie3i4", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }


        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            var student1 = Student._ListaStudentow.First(p => p.Id == 15);
            //var StudentSubjects = Subject.SubjectList.Where(p => p.IsChecked == true);
            foreach (Subject s in student1.ListaWybranychPrzedmiotow)
                MessageBox.Show(s.Name, "Zadanie3i4", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
