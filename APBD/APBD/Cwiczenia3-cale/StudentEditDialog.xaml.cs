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

namespace Cwiczenia3
{
    /// <summary>
    /// Interaction logic for StudentEditDialog.xaml
    /// </summary>
    public partial class StudentEditDialog : Window
    {
        public StudentEditDialog(Models.Student student)
        {
            InitializeComponent();

            ImieEdit.Text = student.Imie;
            NazwiskoEdit.Text = student.Nazwisko;
            NrIndeksuEdit.Text = student.Nazwisko;


        }

        private void Zamknij_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
