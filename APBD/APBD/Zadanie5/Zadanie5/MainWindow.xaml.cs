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
        }

        public void Polaczenie()
        {
            //ListaStudentow = new ObservableCollection<Student>();
            string connectionString = "Data Source=db-mssql;Initial Catalog=s17390;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT o.LastName, o.FirstName, o.IndexNumber, o.Address, s.Name" +
                    "FROM Student o JOIN Studies s ON o.IdStudies = s.IdStudies", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nazwisko = reader["LastName"].ToString();
                        //ListaStudentow.Add(new Student { Nazwisko = nazwisko });
                    }
                }
            }

            //StudentsListBox.ItemsSource = ListaStudentow;
            //StudentsDataGrid.ItemsSource = ListaStudentow;
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
