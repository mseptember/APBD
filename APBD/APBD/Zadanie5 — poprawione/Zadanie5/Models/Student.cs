using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie5.Models;

namespace Zadanie5
{
    class Student
    {
        public static ObservableCollection<Student> _ListaStudentow { get; set; }
        public int Id { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string NrIndeksu { get; set; }
        public string Adres { get; set; }
        public Studies Studia { get; set; }
        public IEnumerable<Subject> ListaWybranychPrzedmiotow { get; set; }
    }
}
