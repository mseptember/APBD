using Cwiczenia3.Models;
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

namespace Cwiczenia3
{
    /// <summary>
    /// Interaction logic for Zadanie3i4.xaml
    /// </summary>
    public partial class Zadanie3i4 : Window
    {
        //private List<Student> studenci = new List<Student>();

        public Zadanie3i4()
        {
            InitializeComponent();

            StudentDataGrid.Items.Add(new Student { Imie = "Jan", Nazwisko = "Kowalski", NrIndeksu = "s1234" });
            StudentDataGrid.Items.Add(new Student { Imie = "Katarzyna", Nazwisko = "Malewska", NrIndeksu = "s2345" });

        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            //Dodajemy tylko gdy mamy poprawnie wypełnione pola TextBoxów
            if (!(string.IsNullOrEmpty(imie.Text) && string.IsNullOrEmpty(nazwisko.Text) && string.IsNullOrEmpty(nrindeksu.Text)))
            {
                
                StudentDataGrid.Items.Add(new Student { Imie = imie.Text, Nazwisko = nazwisko.Text, NrIndeksu = nrindeksu.Text });
                StudentDataGrid.Items.Refresh();

            }


        }

        private void Usun_Click(object sender, RoutedEventArgs e)
        {
            //Usunięcie poprzez wybranie LPM danego studenta z GridDaty
            StudentDataGrid.Items.Remove(StudentDataGrid.SelectedItem);

        }

        private void StudentDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            var student = (Student) StudentDataGrid.SelectedItem;

            var window = new StudentEditDialog(student);
            window.Show();
        }
    }
}
