using Kolokwium1.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Kolokwium1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AnimalDbContext _db;

        public MainWindow()
        {
            InitializeComponent();
            _db = new AnimalDbContext();

            DgvAnimals.ItemsSource = FetchData();
        }

        private void BtnAddAnimal_Click(object sender, RoutedEventArgs e)
        {
            AddAnimalDialog addAnimalDialog = new AddAnimalDialog(_db.AnimalType.ToList(), _db.Owner.ToList());
            addAnimalDialog.ShowDialog();

            if (addAnimalDialog.DialogResult == true)
            {
                try
                {
                    _db.Animal.Add(addAnimalDialog.Animal);
                    _db.SaveChanges();

                    DgvAnimals.ItemsSource = FetchData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd");
                }
            }
        }

        private ICollection<Animal> FetchData()
        {
            try
            {
                return _db.Animal
                          .Include(a => a.AnimalType)
                          .Include(a => a.Owner)
                          .ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd");
                return new List<Animal>();
            }
        }
    }
}
