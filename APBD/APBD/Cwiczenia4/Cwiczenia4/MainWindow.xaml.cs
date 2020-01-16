using Cwiczenia4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Cwiczenia4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Student> ListaStudentow;

        public MainWindow()
        {
            InitializeComponent();


            //LoadDataToListBox1();
            //LoadDataToListBoxAndDataGrid2();
            //ListaStudentow.CollectionChanged += ListaStudentow_CollectionChanged;

            Przyklad1();
           
        }

        private void ListaStudentow_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //MessageBox.Show("Coś się zmieniło w kolekcji");
        }

        private void LoadDataToListBox1()
        {
            StudentsListBox.Items.Add(new ListBoxItem { Content = "Kwiatkowska" });
            StudentsListBox.Items.Add("Wieczorkowski");
            StudentsListBox.Items.Add(new Student { IdStudent = 1, Imie = "Mariusz", Nazwisko = "Kwiatkowski" });
        }

        private void LoadDataToListBoxAndDataGrid2()
        {
            ListaStudentow = new ObservableCollection<Student>();
            ListaStudentow.Add(new Student { IdStudent = 1, Imie = "Jan", Nazwisko = "Kowalski", Plec=true });
            ListaStudentow.Add(new Student { IdStudent = 2, Imie = "Mariusz", Nazwisko = "Głowacki" });

            StudentsListBox.ItemsSource = ListaStudentow;
            StudentsDataGrid.ItemsSource = ListaStudentow;
        }

        private void ShowSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            if (StudentsListBox.SelectedItem == null) //obsłużyć wyjątek żeby program nie wywalał się jak nie zaznaczymy studenta, a chcemy go POKAZAĆ
            {
                MessageBox.Show(StudentsListBox.SelectedItem.ToString());
            }
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            ListaStudentow.Add(new Student { IdStudent = 3, Imie = "AAA", Nazwisko = "BBB"});
            
        }

        public void Przyklad1()
        {
            ListaStudentow = new ObservableCollection<Student>();
            string connectionString = "Data Source=db-mssql;Initial Catalog=s17390;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM emp", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nazwisko = reader["ename"].ToString();
                        ListaStudentow.Add(new Student { Nazwisko = nazwisko});
                    }
                }
            }

            StudentsListBox.ItemsSource = ListaStudentow;
            StudentsDataGrid.ItemsSource = ListaStudentow;

        }
    }
}
