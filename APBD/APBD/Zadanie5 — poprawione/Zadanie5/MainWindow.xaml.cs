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
using Zadanie5.DAL;

namespace Zadanie5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private ObservableCollection<> ListaStudentow;
        public MainWindow()
        {
            InitializeComponent();
            Student._ListaStudentow = StudentsDbService.Polaczenie();
            StudentsDataGrid.ItemsSource = Student._ListaStudentow;
            StudentsDataGrid.Items.Refresh();
        }


        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new DodajStudenta();
            window.ShowDialog();

            //if (window.NewStudent != null)
            //{
            //    var newStudent = window.NewStudent;
            //    var isStudentAdded = StudentDbService.AddRecordToDb(newStudent);
            //    if (isStudentAdded)
            //    {
            //        Student._ListaStudentow.Add(newStudent);
            //        MessageBox.Show("Dodano studenta", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Information);
            //    }
            //}
        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            
            //StudentsDataGrid.Items.Remove(StudentsDataGrid.SelectedItems);
            //StudentsDataGrid.Items.Refresh();
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
