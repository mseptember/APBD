using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie5.Models;

namespace Zadanie5.DAL
{
    class StudentsDbService
    {

        public static ObservableCollection<Student> Polaczenie()
        {
            
            string connectionString = "Data Source=db-mssql;Initial Catalog=s17390;Integrated Security=True";

            ObservableCollection<Student> ListaStudentow = new ObservableCollection<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM s17390.apbd.Student", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //string nazwisko = reader["LastName"].ToString();
                        //string imie = reader["FirstName"].ToString();
                        //string index = reader["IndexNumber"].ToString();
                        //string adres = reader["Address"].ToString();
                        //string studia = reader["Name"].ToString();

                        ListaStudentow.Add(new Student
                        {
                            Id = Convert.ToInt32(reader["IdStudent"]),
                            Nazwisko = reader["LastName"].ToString(),
                            Imie = reader["FirstName"].ToString(),
                            NrIndeksu = reader["IndexNumber"].ToString(),
                            Adres = reader["Address"].ToString(),
                            Studia = Studies._StudiesList.First(o => o.Id == Convert.ToInt32(reader["IdStudies"]))
                        });
                    }
                }
            }

            //StudentsListBox.ItemsSource = ListaStudentow;
            //StudentsDataGrid.ItemsSource = ListaStudentow;
            return ListaStudentow;
        }
    }
}
