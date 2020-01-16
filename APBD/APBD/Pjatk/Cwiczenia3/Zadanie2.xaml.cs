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
    /// Interaction logic for Zadanie2.xaml
    /// </summary>
    public partial class Zadanie2 : Window
    {
        public Zadanie2()
        {
            InitializeComponent();

            Cmb.ItemsSource = new List<string>
            {
                "Student",
                "Skreślony",
                "Absolwent"
            };
        }

        

        private void Zamknij_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Cmb_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Txt.Text = Cmb.SelectedValue.ToString();
        }

     
    }
}
