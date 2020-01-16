using KolokwiumAPBD.DAL;
using KolokwiumAPBD.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KolokwiumAPBD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmployeeDbService _service;
        public MainWindow()
        {
            InitializeComponent();
            _service = new EmployeeDbService();

            EmpsDataGrid.ItemsSource = _service.GetEmps();
            DepartmentComboBox.ItemsSource = _service.GetDepts();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text.Length < 100)
            {
                var text = SearchTextBox.Text;
                EmpsDataGrid.ItemsSource = _service.GetSearchedRecords(text);
            }
            else
                MessageBox.Show("Wprowadzono za dużo znaków", "DeansOffice", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            EmpsDataGrid.ItemsSource = _service.GetEmps();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            var tmpName = NameTextBox.Text;
            var tmpJob = JobTextBox.Text;

            if (!string.IsNullOrEmpty(tmpName) && !string.IsNullOrEmpty(tmpJob) && DepartmentComboBox.SelectedItem != null)
            {
                if (tmpName.Length <= 10 && tmpJob.Length <= 9)
                {
                    var tmpDept = ((DEPT)DepartmentComboBox.SelectedItem);

                    var newEmp = new EMP
                    {
                        EMPNO = _service.GetHighestId() + 1,
                        ENAME = tmpName,
                        JOB = tmpJob,
                        DEPT = tmpDept
                    };
                    _service.AddEmp(newEmp);
                    EmpsDataGrid.ItemsSource = _service.GetEmps();
                    ClearFields();
                }
                else
                    MessageBox.Show("Wpisano za dużo znaków", "EmpsWindow", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBox.Show("Co najmniej jedno pole jest puste", "EmpsWindow", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        private void ClearFields()
        {
            NameTextBox.Text = "";
            JobTextBox.Text = "";
            DepartmentComboBox.SelectedItem = null;
        }
    }
}
