using APBD5.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace APBD5.DAL
{

    public static class StudentDbService
    {
        private static string connectionString = "Data Source=db-mssql.pjwstk.edu.pl;Initial Catalog=s17110;Integrated Security=True";
        internal static ObservableCollection<Student> PullStudentsFromDbToList()
        {
            ObservableCollection<Student> ListaStudentowTmp = new ObservableCollection<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                SqlTransaction transaction = con.BeginTransaction();

                command.Connection = con;
                command.Transaction = transaction;
                try
                {
                    command.CommandText = "SELECT * FROM s17110.apbd.Student";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListaStudentowTmp.Add(new Student
                            {
                                Id = Convert.ToInt32(reader["IdStudent"]),
                                Nazwisko = reader["LastName"].ToString(),
                                Imie = reader["FirstName"].ToString(),
                                NrIndeksu = reader["IndexNumber"].ToString(),
                                Adres = reader["Address"].ToString(),
                                Studia = Studies._StudiesList.First(o => o.Id == Convert.ToInt32(reader["IdStudies"])),
                            });
                        }
                    }

                    int subjectId;
                    foreach (Student student in ListaStudentowTmp)
                    {
                        command.CommandText = $"SELECT IdSubject FROM apbd.Student_Subject WHERE IdStudent = {student.Id}";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                subjectId = Convert.ToInt32(reader["IdSubject"]);

                                student.ListaWybranychPrzedmiotow.Add(Subject._SubjectList.First(subject => subject.Id == subjectId));
                            }
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania danych", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Error);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Połączenie zostało zerwane", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }

            return ListaStudentowTmp;
        }

        internal static List<Subject> PullSubjectsFromDB()
        {
            List<Subject> SubjectList = new List<Subject>();


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM s17110.apbd.Subject", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SubjectList.Add(new Subject
                        {
                            Id = Convert.ToInt32(reader["IdSubject"]),
                            Name = reader["Name"].ToString(),
                            IsChecked = false
                        });

                    }
                }
            }
            return SubjectList;
        }

        internal static bool EditRecordInDb(Student orginalStudent, Student editedStudent)
        {
            string updateStudentQuery = $"UPDATE apbd.Student " +
                $"SET FirstName = '{editedStudent.Imie}', LastName = '{editedStudent.Nazwisko}', Address = '{editedStudent.Adres}', IndexNumber = '{editedStudent.NrIndeksu}', IdStudies = {editedStudent.Studia.Id}  " +
                $"WHERE IdStudent = {orginalStudent.Id};";

            List<int> SubjectsIdToAdd = new List<int>();
            foreach (Subject subject in editedStudent.ListaWybranychPrzedmiotow)
            {
                if (!orginalStudent.ListaWybranychPrzedmiotow.Contains(subject)) {
                    SubjectsIdToAdd.Add(subject.Id);
                }
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                SqlTransaction transaction = con.BeginTransaction();
                command.Connection = con;
                command.Transaction = transaction;
                try
                {
                    //update Student
                    command.CommandText = updateStudentQuery;
                    command.ExecuteNonQuery();

                    //update student_subject
                    foreach (Subject subject in Subject._SubjectList)
                    {
                        if (!editedStudent.ListaWybranychPrzedmiotow.Contains(subject))
                        {
                            //command.CommandText = $"DELETE FROM apbd.Student_Subject WHERE IdStudent = {orginalStudent.Id} AND IdSubject = {subject.Id}";
                            //command.ExecuteNonQuery();
                        }
                    }
                    foreach (int id in SubjectsIdToAdd) {
                        command.CommandText = $"INSERT INTO s17110.apbd.Student_Subject (IdStudent, IdSubject, CreatedAt) VALUES ({orginalStudent.Id}, {id}, GETDATE())";
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(//"Wystąpił błąd podczas edycji studenta" +
                        e.Source, "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Error);

                    try
                    {
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Połączenie zostało zerwane", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                }
            }
        }

        internal static List<Studies> PullStudiesFromDB()
        {
            List<Studies> StudiesList = new List<Studies>();


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM s17110.apbd.Studies", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudiesList.Add(new Studies
                        {
                            Id = Convert.ToInt32(reader["IdStudies"]),
                            Name = reader["Name"].ToString()
                        });

                    }
                }
            }
            return StudiesList;
        }

        internal static bool RemoveFromDb(IList listOfStudentsToRemove)
        {
            var removedStudentsId = new List<int>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                SqlTransaction transaction = con.BeginTransaction("SampleTransaction");

                command.Connection = con;
                command.Transaction = transaction;
                try
                {
                    foreach (int Id in listOfStudentsToRemove)
                    {
                        command.CommandText = $"DELETE FROM s17110.apbd.Student_Subject WHERE IdStudent = {Id}";
                        command.ExecuteNonQuery();

                        command.CommandText = $"DELETE FROM s17110.apbd.Student WHERE IdStudent = {Id}";
                        command.ExecuteNonQuery();

                    }
                    transaction.Commit();

                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił błąd podczas usuwania studentów", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Error);

                    try
                    {
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Połączenie zostało zerwane", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                }
            }
        }

        public static bool AddRecordToDb(Student student)//obsłużyć błędy !!!! unikatowe indeksy
        {
            string AddStudentQuery = $"INSERT INTO s17110.apbd.Student(FirstName, LastName, Address, IndexNumber, IdStudies) " +
                                 $"VALUES ('{student.Imie}', '{student.Nazwisko}', 'Ulica i miasto', '{student.NrIndeksu}', {student.Studia.Id})";

            string GetAddedStudentId = $"SELECT IdStudent FROM s17110.apbd.Student WHERE (FirstName = '{student.Imie}' AND LastName = '{student.Nazwisko}' AND IndexNumber = '{student.NrIndeksu}')";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                SqlTransaction transaction = con.BeginTransaction("SampleTransaction");
                command.Connection = con;
                command.Transaction = transaction;
                try
                {
                    //adding Student
                    command.CommandText = AddStudentQuery;
                    command.ExecuteNonQuery();

                    //getting student Id
                    command.CommandText = GetAddedStudentId;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            student.Id = Convert.ToInt32(reader["IdStudent"]);
                    }

                    //adding subjects to student
                    foreach (Subject subject in student.ListaWybranychPrzedmiotow)
                    {
                        command.CommandText = $"INSERT INTO s17110.apbd.Student_Subject (IdStudent, IdSubject, CreatedAt) VALUES ({student.Id}, {subject.Id}, GETDATE())";
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();

                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił błąd podczas dodawania studenta", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Error);

                    try
                    {
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Połączenie zostało zerwane", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                }
            }
        }
    }
}
