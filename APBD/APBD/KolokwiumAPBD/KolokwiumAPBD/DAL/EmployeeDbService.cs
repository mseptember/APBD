using KolokwiumAPBD.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KolokwiumAPBD.DAL
{
    class EmployeeDbService
    {
        private EmployeeDbContext _context;

        public EmployeeDbService()
        {
            _context = new EmployeeDbContext();
        }

        internal IEnumerable GetEmps()
        {
            return _context.EMPs.ToList();
        }

        public IEnumerable GetSearchedRecords(string text)
        {
            //var emps = _context.EMPs.ToList().Where();
            return _context.EMPs.ToList().Where(e => e.ENAME == text);
        }

        internal void AddEmp(EMP newEmp)
        {
            try
            {
                _context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                _context.EMPs.Add(newEmp);
                _context.SaveChanges();
                MessageBox.Show("Dodano pracownika", "EmpsWindow", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd", "EmpsWindow", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        internal IEnumerable GetDepts()
        {
            return _context.DEPTs.ToList();
        }

        public int GetHighestId()
        {
            return _context.EMPs.ToList().Max(e => e.EMPNO);
        }
    }
}
