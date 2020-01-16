using Kolokwium1.DAL;
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

namespace Kolokwium1
{
    public partial class AddAnimalDialog : Window
    {
        public Animal Animal { get; set; }

        public AddAnimalDialog(ICollection<AnimalType> animalTypes, ICollection<Owner> owners)
        {
            InitializeComponent();
            CmbOwner.ItemsSource = owners;
            CmbAnimalType.ItemsSource = animalTypes;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            Animal = new Animal
            {
                Name = TxtAnimalName.Text,
                AnimalType = CmbAnimalType.SelectedItem as AnimalType,
                Owner = CmbOwner.SelectedItem as Owner
            };

            DialogResult = true;
            Close();
        }
    }
}
