using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD5.Models
{
    public class Student
    {
        public static ObservableCollection<Student> _ListaStudentow { get; set; }
        public int Id { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string NrIndeksu { get; set; }
        public string Adres { get; set; }
        public Studies Studia { get; set; }
        private IList<Subject> listaWybranychPrzedmiotow = new List<Subject>();
        public IList<Subject> ListaWybranychPrzedmiotow { get => listaWybranychPrzedmiotow; set => listaWybranychPrzedmiotow = value; }

    }
}
