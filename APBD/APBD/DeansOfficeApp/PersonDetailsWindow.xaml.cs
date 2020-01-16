using DeansOfficeApp.Models;
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

namespace DeansOfficeApp
{
    /// <summary>
    /// Interaction logic for PersonDetailsWindow.xaml
    /// </summary>
    public partial class PersonDetailsWindow : Window
    {
        public PersonDetailsWindow()
        {
            InitializeComponent();

            var studenci = new List<Student>();
            studenci.Add(new Student { FirstName = "Jan", LastName = "Kowalski", IndexNumber = "s1234", Year = 2018, Semester = "2017/2018 letni", Specialization = "Bazy danych", Status = "Student", Notes = "Brak" });

            WpisyNaSemestrDataGrid.ItemsSource = studenci;

            if (Convert.ToInt32(SaldoTextBox.Text) < 0)
            {
                SaldoTextBox.Background = Brushes.IndianRed;
            }
            else if (Convert.ToInt32(SaldoTextBox.Text) > 0)
            {
                SaldoTextBox.Background = Brushes.LightGreen;
            }
            else
            {
                SaldoTextBox.Background = Brushes.White;
            }
        }
    }
}
